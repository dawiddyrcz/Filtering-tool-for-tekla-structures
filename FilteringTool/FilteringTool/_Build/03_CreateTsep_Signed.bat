set version=5.3
set batchBuilder="%TEKLA_2023_BINDIR%\TeklaExtensionPackage.BatchBuilder.exe"
set folderName=DDBIMFilteringTool

set certificateFile=%CODE_SIGN_CERT_FILE%
set certificateSHA=%CODE_SIGN_CERT_SHA%

set outdir=%userprofile%\desktop\tsep-output\%folderName%\tsep
set logDir=%userprofile%\desktop
mkdir "%outdir%"

set tsepName=DDBIMFilteringTool_Tekla2016-2024
set infile=%CD%\..\_Assets\TsepDefinition.xml
set outfile=%outdir%\%tsepName%.tsep
%batchBuilder% -i "%infile%" -o "%outfile%" -l "%logDir%" -s "%certificateFile%" -v "%version%" -t -a
echo Exit Code is %errorlevel%

set tsepName=DDBIMFilteringTool_Tekla2025_or_newer
set infile=%CD%\..\_Assets\TsepDefinition_2025plus.xml
set outfile=%outdir%\%tsepName%.tsep
%batchBuilder% -i "%infile%" -o "%outfile%" -l "%logDir%" -v "%version%" -t -a
echo Exit Code is %errorlevel%

set fileName=%tsepName%_%version%
ren "%outdir%\%fileName%.tsep" "%fileName%.nupkg"
sign code certificate-store "%outdir%\%fileName%.nupkg" --certificate-fingerprint %certificateSHA% -v error
ren "%outdir%\%fileName%.nupkg" "%fileName%.tsep"

PAUSE