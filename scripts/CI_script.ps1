param(
    [string]$RepoUrl = "https://github.com/Kulichok26/Calculator.git",
    [string]$Branch = "main",
    [string]$BuildPath = "E:\CI\Build",
    [string]$RepoPath = "E:\CI\Repo",
    [string]$IssFilePath = "C:\YourProject\InstallerScript.iss"  # Путь к .iss файлу
)

# 1. Загрузка актуального состояния с сервера (Git)
Write-Host "1. Загрузка репозитория..." -ForegroundColor Green
if (Test-Path $RepoPath) {
    Set-Location $RepoPath
    git pull origin $Branch
} else {
    git clone $RepoUrl $RepoPath
    Set-Location $RepoPath
}

# 2. Сборка проекта и тестов
Write-Host "2. Сборка проекта и тестов..." -ForegroundColor Green
$SolutionPath = Get-ChildItem -Path $RepoPath -Filter "*.sln" -Recurse | Select-Object -First 1

if (-not $SolutionPath) {
    Write-Host "Решение (.sln) не найдено!" -ForegroundColor Red
    exit 1
}

# Сборка Debug конфигурации
msbuild $SolutionPath.FullName /p:Configuration=Debug /p:Platform="Any CPU"

# Проверяем, есть ли отдельный проект с тестами
$TestProjects = Get-ChildItem -Path $RepoPath -Filter "*test*.csproj" -Recurse

# 3. Выполнение unit-тестов
Write-Host "3. Запуск unit-тестов..." -ForegroundColor Green
foreach ($testProj in $TestProjects) {
    # Для xUnit используем dotnet test
    dotnet test $testProj.FullName --verbosity normal
    
    if ($LASTEXITCODE -ne 0) {
        Write-Host "Тесты провалились!" -ForegroundColor Red
        exit 1
    }
}

# 4. Сборка Release конфигурации для установщика
Write-Host "4. Сборка Release версии..." -ForegroundColor Green
msbuild $SolutionPath.FullName /p:Configuration=Release /p:Platform="Any CPU"

# 5. Создание установщика (Inno Setup)
Write-Host "5. Создание установщика..." -ForegroundColor Green
if (Test-Path $IssFilePath) {
    # Путь к Inno Setup Compiler (ISCC.exe)
    $ISCCPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
    
    if (Test-Path $ISCCPath) {
        & $ISCCPath $IssFilePath
        
        if ($LASTEXITCODE -eq 0) {
            # Ищем созданный установщик
            $SetupDir = Split-Path $IssFilePath -Parent
            $SetupExe = Get-ChildItem -Path $SetupDir -Filter "*.exe" -Recurse | 
                       Where-Object { $_.Name -match "setup" } | 
                       Select-Object -First 1
            
            if ($SetupExe) {
                Write-Host "Установщик создан: $($SetupExe.FullName)" -ForegroundColor Green
                
                # 6. Установка приложения (опционально)
                Write-Host "6. Установка приложения..." -ForegroundColor Green
                # ВНИМАНИЕ: Установка может требовать прав администратора
                # Start-Process $SetupExe.FullName -Wait
                Write-Host "Установка пропущена (закомментируйте строку выше для запуска)" -ForegroundColor Yellow
            }
        } else {
            Write-Host "Ошибка создания установщика!" -ForegroundColor Red
        }
    } else {
        Write-Host "Inno Setup не найден по пути: $ISCCPath" -ForegroundColor Red
    }
} else {
    Write-Host "Файл .iss не найден: $IssFilePath" -ForegroundColor Red
}

Write-Host "CI процесс завершен успешно!" -ForegroundColor Green