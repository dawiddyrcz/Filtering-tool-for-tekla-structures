echo on
set msbuild="%MSBUILD_EXE_LOCATION%"
%msbuild% %CD%\..\..\FilteringToolSetup_InstallerClass\FilteringToolSetup_InstallerClass.csproj /t:Rebuild /p:Configuration=Debug
PAUSE