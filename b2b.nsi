; b2b.nsi
;
; This script is based on example1.nsi, but it remember the directory, 
; has uninstall support and (optionally) installs start menu shortcuts.
;
; It will install b2b.nsi into a directory that the user selects,

;--------------------------------
; The name of the installer
Name "B2B"
Caption "B2B - СМС рассылка"
Icon "b2b.ico"

; The file to write
OutFile "setup.exe"

; The default installation directory
InstallDir "$PROGRAMFILES\B2B"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\B2B" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------
; MUI Settings
!include "MUI.nsh"
!include "DotNetChecker.nsh"

!define PRODUCT_NAME "B2B"
!define PRODUCT_PUBLISHER "Софт Сити"
!define MUI_ABORTWARNING
!define MUI_ICON "b2b.ico"
!define MUI_UNICON "b2b.ico"
!define MUI_COMPONENTSPAGE_SMALLDESC

!insertmacro MUI_RESERVEFILE_LANGDLL
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
   
; Installer pages
!define MUI_WELCOMEPAGE_TITLE_3LINES
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!define MUI_FINISHPAGE_RUN "$INSTDIR\b2b.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
;!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

; Components page!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_LANGUAGE "Russian"

;--------------------------------
; Pages

;Page components
;Page directory
;Page instfiles

;UninstPage uninstConfirm
;UninstPage instfiles

;--------------------------------
;Functions checking for .NET presence
 

;--------------------------------
;Installer Sections
Section "B2B (требуется)" SEC01

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  SetOverwrite on
  
  !insertmacro CheckNetFramework 35
  
  ; Put file there
  File /r "D:\Документы\Visual Studio 2012\Projects\SendSms\SendSms\bin\Release\"
  
  ; Write the installation path into the registry
  WriteRegStr HKLM "SOFTWARE\B2B" "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\B2B" "DisplayName" "B2B"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\B2B" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\B2B" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\B2B" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
  
SectionEnd

; Optional section (can be disabled by the user)
Section "Ярлык в меню Пуск" SEC02

  CreateDirectory "$SMPROGRAMS\B2B"
  CreateShortCut "$SMPROGRAMS\B2B\Удалить B2B.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  CreateShortCut "$SMPROGRAMS\B2B\B2B.lnk" "$INSTDIR\b2b.exe" "" "$INSTDIR\b2b.exe" 0
  
SectionEnd

Section "Ярлык на Рабочий стол" SEC03
  SectionIn 1 2 3
  CreateShortCut "$DESKTOP\B2B.lnk" \
    "$INSTDIR\b2b.exe" ""
SectionEnd

;--------------------------------
; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\B2B"
  DeleteRegKey HKLM "SOFTWARE\B2B"

  ; Remove files and uninstaller
  Delete $INSTDIR\*.*
  Delete $INSTDIR\x64\*.*
  Delete $INSTDIR\x86\*.*
  ;Delete $INSTDIR\uninstall.exe

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\B2B\*.*"
  Delete "$DESKTOP\B2B.lnk"

  ; Remove directories used
  RMDir "$SMPROGRAMS\B2B"
  RMDir /r "$INSTDIR"

SectionEnd


!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} "Дистрибутив программы"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC02} "Добавляет значки в меню Пуск для быстрого доступа"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC03} "Добавляет значок на Рабочий стол для быстрого доступа"
!insertmacro MUI_FUNCTION_DESCRIPTION_END