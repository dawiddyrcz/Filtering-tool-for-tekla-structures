echo on
set pluginname={DDBIM Filtering Tool}

echo "Confirm 3 times"
PAUSE
PAUSE
PAUSE

set tsversion=2026.0
"C:\TeklaStructures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\TeklaStructures\%tsversion%" 0
set extensionDir="C:\TeklaStructures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\TeklaStructures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\TeklaStructures\%tsversion%" 0

set tsversion=2025.0
"C:\TeklaStructures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\TeklaStructures\%tsversion%" 0
set extensionDir="C:\TeklaStructures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\TeklaStructures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\TeklaStructures\%tsversion%" 0

set tsversion=2024.0
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2023.0
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2022.0
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2021.0
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2020.0
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2019.0
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2019.1
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Trimble\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Trimble\Tekla Structures\%tsversion%" 0

set tsversion=2018
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

set tsversion=2018i
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

set tsversion=2017
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

set tsversion=2017i
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

set tsversion=2016
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

set tsversion=2016i
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0
set extensionDir="C:\ProgramData\Tekla Structures\%tsversion%\Extensions\Installed\%pluginname%*"
cd %extensionDir%
copy NUL "RemoveExtensionOnStartup"
cd "C:\"
"C:\Program Files\Tekla Structures\%tsversion%\nt\bin\TeklaExtensionPackage.TepAutoInstaller.exe" %tsversion% "C:\ProgramData\Tekla Structures\%tsversion%" 0

PAUSE