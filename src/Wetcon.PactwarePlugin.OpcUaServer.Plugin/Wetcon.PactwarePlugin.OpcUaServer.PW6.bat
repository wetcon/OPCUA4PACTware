set WORKING_DIRECTORY=%~dp0
set KEY="HKLM\Software\Wow6432Node\PACTware\PACTware 6.0\PWADDIN\{2487DD09-1566-4CF9-A604-6AD3148B3858}"

reg add %KEY% /d "OpcUaServer Plugin" /f
reg add %KEY% /v "Manufacturer" /d "wetcon GmbH" /f
reg add %KEY% /v "Object" /d "OpcUaPlugin" /f
reg add %KEY% /v "Path" /d "%WORKING_DIRECTORY%bin\PW6\Debug\Wetcon.PactwarePlugin.OpcUaServer.dll" /f
reg add %KEY% /v "State" /t REG_DWORD /d 00000001 /f

pause
