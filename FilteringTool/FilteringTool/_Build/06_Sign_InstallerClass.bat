echo on
signtool sign /n "%CODE_SIGN_CERT_NAME%" /t http://time.certum.pl/ /fd sha256 /v^
 "..\..\FilteringToolSetup_InstallerClass\bin\Debug\FilteringToolSetup_InstallerClass.dll"
PAUSE