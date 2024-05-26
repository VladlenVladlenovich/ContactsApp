#define MyAppName "ContactsApp"
#define MyAppExeName "ContactsAppUI.exe"
#define MyAppVersion "1.0"
#define MyAppPublisher "Vladimir Gorbunov"

[Setup]
AppId={{300F9068-F066-4B90-A696-2292DE88C621}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}

; ���� ��������� ��-���������
DefaultDirName={pf}\{#MyAppExeName}

; �������, ���� ����� ������� ��������� setup � ��� ������������ �����
OutputDir="Installers"
OutputBaseFileName=ContactsAppSetup

; ��������� ������
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl";
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

[Tasks]
; �������� ������ �� ������� �����
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\ContactsAppUI\bin\Release\ContactsAppUI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\ContactsAppUI\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

