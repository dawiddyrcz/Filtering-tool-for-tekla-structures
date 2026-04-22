echo on
devenv "%CD%\..\..\FilteringToolSetup\FilteringToolSetup.vdproj" /build Debug
explorer "%CD%\..\..\FilteringToolSetup\Debug\"
PAUSE