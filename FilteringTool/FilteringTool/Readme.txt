How filtering tool works?

Filtering tool is version independent application. How it works:

1. Filtering tool starter (FilteringToolStarter.exe) check which version of Tekla Structures is running.
2. Then starter copies Filtering tool (FilteringTool.exe) and create config file (FilteringTool.exe.config) 
to System Temp folder (Usually: C:\Users\UserName\Appdata\Local\Temp).
3. Then starter runs application from temp folder. Application loads Tekla API dlls in versions from config file.

Build solution and then open solution output folder to get output. 
Alternatively you can install Filtering Tool from the Filtering Tool Setup Project
