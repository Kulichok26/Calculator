# ci-script.ps1
# Скрипт непрерывной интеграции для проекта C# калькулятора
# Автоматически выполняет: pull, сборку, тесты, создание установщика, установку

param(
    [string]$ProjectPath = ".",
    [string]$BuildConfiguration = "Release",
    [string]$InstallerName = "CalculatorSetup"
)

Write-Host "=== Начало CI-процесса ===" -ForegroundColor Green

# 1. Загрузка актуального состояния (если это Git-репозиторий)
Write-Host "1. Загрузка актуального состояния..." -ForegroundColor Yellow
if (Test-Path "$ProjectPath\.git") {
    git pull origin main
} else {
    Write-Host "   Git-репозиторий не найден, пропускаем шаг." -ForegroundColor Gray
}

# 2. Сборка проекта
Write-Host "2. Сборка проекта..." -ForegroundColor Yellow
$solutionPath = Join-Path $ProjectPath "Calculator.sln"
if (Test-Path $solutionPath) {
    dotnet restore $solutionPath
    dotnet build $solutionPath --configuration $BuildConfiguration --no-restore
} else {
    Write-Host "   Файл решения не найден!" -ForegroundColor Red
    exit 1
}

# 3. Выполнение unit-тестов
Write-Host "3. Запуск unit-тестов..." -ForegroundColor Yellow
$testProjectPath = Join-Path $ProjectPath "TestProject\TestProject.csproj"
if (Test-Path $testProjectPath) {
    dotnet test $testProjectPath --configuration $BuildConfiguration --no-build
} else {
    Write-Host "   Тестовый проект не найден!" -ForegroundColor Red
    exit 1
}

# 4. Создание установщика (Inno Setup)
Write-Host "4. Создание установщика..." -ForegroundColor Yellow
$issScriptPath = Join-Path $ProjectPath "installer.iss"
if (Test-Path $issScriptPath) {
    $innoSetupPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
    if (Test-Path $innoSetupPath) {
        & $innoSetupPath $issScriptPath
        Write-Host "   Установщик создан." -ForegroundColor Green
    } else {
        Write-Host "   Inno Setup не установлен!" -ForegroundColor Red
    }
} else {
    Write-Host "   Скрипт Inno Setup не найден!" -ForegroundColor Red
}

# 5. Установка приложения (опционально, обычно в CI пропускается)
Write-Host "5. Установка приложения..." -ForegroundColor Yellow
$installerExe = Join-Path $ProjectPath "Output\$InstallerName.exe"
if (Test-Path $installerExe) {
    Write-Host "   Запуск установщика в тихом режиме..." -ForegroundColor Gray
    Start-Process -FilePath $installerExe -ArgumentList "/VERYSILENT /SUPPRESSMSGBOXES" -Wait
} else {
    Write-Host "   Установщик не найден!" -ForegroundColor Red
}

Write-Host "=== CI-процесс завершён ===" -ForegroundColor Green