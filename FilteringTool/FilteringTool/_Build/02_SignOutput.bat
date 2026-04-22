echo on
signtool sign /n "%CODE_SIGN_CERT_NAME%" /t http://time.certum.pl/ /fd sha256 /v^
	"..\bin\Debug\FilteringTool.exe"^
	"..\..\FilteringToolPlugin\bin\Debug\FilteringToolPlugin.dll"^
	"..\bin\Debug\Newtonsoft.Json.dll"
PAUSE