set targetfile=%~1
set folderToUse=%~2
echo %targetfile%

xcopy /Y /S %targetfile% "F:\Clarity-Servers\resources\[Scripts]\qdx_core\%folderToUse%"
xcopy /Y /S %targetfile% "F:\Git-Projects\qdx_core\Client\MenuUI\%folderToUse%"
xcopy /Y /S %targetfile% "F:\QDX-Test-Environment\resources\[Other Scripts]\ScaleformUI\%folderToUse%"

:: cd /d F:\Clarity-Servers
:: >>starter.bat echo exit

:: For copying dlls to specific folders: $(SolutionDir)build.bat "$(TargetDir)$(TargetFileName)" "Client/Server"