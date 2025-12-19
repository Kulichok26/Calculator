;--------------------------------------------------------------------
;Определяем переменные, которые дальше будут использоваться  скрипте
;--------------------------------------------------------------------


;имя приложения
#define MyAppName "Calculator"
;версия приложения - в нашем случае всё равно, т.к. дальнейшая разработка не планируется
#define MyAppVersion "1.0"
;компания издатель - в нашем случае всё равно
#define MyAppPublisher "Kulikova_Filimonova"
;имя финального файла-установщика
#define MyAppExeName "Calculator.exe"
;папка, которую я использую для создания установщика - адрес в моём компьютере
#define SourceDir "F:\university\5 sem\PROJECT\projectFilimonovaKulikova\bin\Release\net8.0-windows\win-x64\"

;-------------------------------------------------------------------
;Основные устройства установщика
;-------------------------------------------------------------------

[Setup]
;уникальный id приложения, генерируется онлайн
AppId={{231CA39F-7702-42EA-A26D-054C67E3D979}
;название приложения, через знак решётки подставляется значение ранее определённой переменной
AppName={#MyAppName}
;версия
AppVersion={#MyAppVersion}
;компания издатель
AppPublisher={#MyAppPublisher}
;папка установки по умолчанию, autopf - путь к папке ProgramFiles
DefaultDirName={autopf}\{#MyAppName}
;название группы в меню "поиск"
DefaultGroupName={#MyAppName}
;куда сохранится установщик, относительный путь: оно сохранися в папку SetupOutput рядом с этим скриптом
OutputDir=SetupOutput
;имя файла установщика
OutputBaseFilename=CalculatorSetup
;алгоритм сжатия
Compression=lzma
;улучшенное сжатие
SolidCompression=yes
;стиль мастера установки
WizardStyle=modern
;достаточно минимальных прав
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog

;----------------------------------------------------------------------
;Определение языков (для мастера установки)
;----------------------------------------------------------------------

[Languages]
;для английского языка
Name: "english"; MessagesFile: "compiler:Default.isl"; LicenseFile: "License.txt"
;для русского языка
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "License.txt"

;-----------------------------------------------------------------------
;Дополнительные задачи
;-----------------------------------------------------------------------

[Tasks]
;задача создания ярлыка на рабочем столе
Name: "desktopicon"; Description: "Создать значок на рабочем столе"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

;-----------------------------------------------------------------------
;Пути к файлам
;-----------------------------------------------------------------------

[Files]
;копируются все необходимые файлы
Source: "{#SourceDir}*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs
Source: "calculator_3534.ico"; DestDir: "{app}"; Flags: ignoreversion

;-----------------------------------------------------------------------
;Создание ярлыков
;-----------------------------------------------------------------------

[Icons]
;создаётся в меню "Пуск"
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\calculator_3534.ico"
;создаётся при выполнении задачи с созданием ярлыка
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\calculator_3534.ico"; Tasks: desktopicon

;------------------------------------------------------------------------
;Выполнение после установки
;------------------------------------------------------------------------

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
//проверка наличия .NET 8 Desktop Runtime
function IsDotNet8Installed(): Boolean;
var
  regPath: string;
begin
  //проверка для x64 систем
  regPath := 'SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedfx\Microsoft.WindowsDesktop.App';
  
  if RegKeyExists(HKLM, regPath) then
  begin
    Log('.NET 8 Desktop Runtime найден в HKLM');
    Result := True;
  end
  else
  begin
    //проверка для x86 систем
    regPath := 'SOFTWARE\dotnet\Setup\InstalledVersions\x86\sharedfx\Microsoft.WindowsDesktop.App';
    if RegKeyExists(HKLM, regPath) then
    begin
      Log('.NET 8 Desktop Runtime найден в HKLM (x86)');
      Result := True;
    end
    else
    begin
      Log('.NET 8 Desktop Runtime не найден');
      Result := False;
    end;
  end;
end;

function InitializeSetup(): Boolean;
var
  ErrorCode: Integer;
begin
  //проверяем наличие .NET 8
  if not IsDotNet8Installed() then
  begin
    if MsgBox('Для работы приложения требуется .NET 8 Desktop Runtime.' + #13#10 +
              'Установить его сейчас?', mbConfirmation, MB_YESNO) = IDYES then
    begin
      //открываем страницу загрузки .NET 8
      ShellExec('open', 'https://dotnet.microsoft.com/download/dotnet/8.0', '', '', SW_SHOW, ewNoWait, ErrorCode);
    end;
    
    MsgBox('Установите .NET 8 Desktop Runtime и запустите установку заново.',
           mbCriticalError, MB_OK);
    Result := False;
  end
  else
  begin
    Result := True;
  end;
end;