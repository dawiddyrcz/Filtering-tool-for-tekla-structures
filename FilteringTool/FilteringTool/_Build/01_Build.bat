echo on
set msbuild="%MSBUILD_EXE_LOCATION%"
set loglevel=m
rem loglevel  q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic].
del %CD%\..\bin\Debug\*.* /F /Q
%msbuild% %CD%\..\..\FilteringTool\FilteringTool.csproj /t:Build /p:Configuration=Debug /v:%loglevel%
%msbuild% %CD%\..\..\FilteringToolPlugin\FilteringToolPlugin.csproj /t:Build /p:Configuration=Debug /v:%loglevel%

PAUSE