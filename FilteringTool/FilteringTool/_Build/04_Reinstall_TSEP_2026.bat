echo on
set TEP_COMMAND="%TEKLA_2026_BINDIR%\TeklaExtensionPackage.TepAutoInstaller.exe" 2026.0 "%TEKLA_2026_ENVDIR%" 0
set extensionDir="%TEKLA_2026_ENVDIR%\Extensions\Installed\{DDBIM Filtering Tool}*"
set extensionDir2="%TEKLA_2026_ENVDIR%\Extensions\Installed\{Dev DDBIM Filtering Tool}*"
cd "C:\"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd %extensionDir2%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
%TEP_COMMAND%
PAUSE
copy "%userprofile%\Desktop\tsep-output\DDBIMFilteringTool\tsep\*.tsep" "%TEKLA_2026_ENVDIR%\Extensions\To be installed\"
%TEP_COMMAND%
PAUSE