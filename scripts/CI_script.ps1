# CI_Script.ps1 (70 строк)

param(
    [string]$RepoUrl = "https://github.com/yourusername/yourproject.git",
    [string]$RepoPath = ".\Repo"
)

# 1. Загрузка актуального состояния
Write-Host "1. Загрузка репозитория..." -ForegroundColor Green
if (Test-Path $RepoPath) {
    Set-Location $RepoPath; git pull
} else {
    git clone $RepoUrl $RepoPath; Set-Location $RepoPath
}

# Проверка необходимых инструментов
$tools = @("git", "msbuild", "dotnet")
foreach ($t in $tools) {
    if (-not (Get-Command $t -ErrorAction SilentlyContinue)) {
        Write-Host "Ошибка: $t не найден" -ForegroundColor Red; exit 1
    }
}

# 2. Сборка проекта и тестов
Write-Host "2. Сборка проекта..." -ForegroundColor Green
$sln = Get-ChildItem -Filter "*.sln" | Select-Object -First 1
if (-not $sln) { Write-Host "Не найден .sln файл" -ForegroundColor Red; exit 1 }

msbuild $sln.Name /p:Configuration=Release /p:Platform="Any CPU"
if ($LASTEXITCODE -ne 0) { Write-Host "Сборка провалилась" -ForegroundColor Red; exit 1 }

# 3. Выполнение unit-тестов
Write-Host "3. Запуск тестов..." -ForegroundColor Green
$testProjects = Get-ChildItem -Filter "*test*.csproj"
foreach ($test in $testProjects) {
    dotnet test $test.Name --verbosity minimal
    if ($LASTEXITCODE -ne 0) { Write-Host "Тесты провалились" -ForegroundColor Red; exit 1 }
}

# 4. Создание установщика
Write-Host "4. Создание установщика..." -ForegroundColor Green
$issPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
if (-not (Test-Path $issPath)) {
    Write-Host "Inno Setup не найден" -ForegroundColor Red; exit 1
}

$issFile = Get-ChildItem -Filter "*.iss" | Select-Object -First 1
if ($issFile) {
    & $issPath $issFile.Name
    if ($LASTEXITCODE -ne 0) { Write-Host "Ошибка создания установщика" -ForegroundColor Red; exit 1 }
}

# 5. Установка приложения
Write-Host "5. Установка приложения..." -ForegroundColor Green
$setupExe = Get-ChildItem -Filter "*setup*.exe" | Select-Object -First 1
if ($setupExe) {
    Write-Host "Найден установщик: $($setupExe.Name)" -ForegroundColor Cyan
    Write-Host "Для установки раскомментируйте следующую строку:" -ForegroundColor Yellow
    Write-Host "# Start-Process $($setupExe.Name) -Wait" -ForegroundColor Gray
}

Write-Host "`n✅ CI процесс завершен!" -ForegroundColor Green