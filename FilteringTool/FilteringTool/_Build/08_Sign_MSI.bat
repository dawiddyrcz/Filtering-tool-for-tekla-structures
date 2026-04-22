echo on
signtool sign /n "%CODE_SIGN_CERT_NAME%" /t http://time.certum.pl/ /fd sha256 /v^
 "..\..\FilteringToolSetup\Debug\*.msi"
 explorer "%CD%\..\..\FilteringToolSetup\Debug\"
PAUSE