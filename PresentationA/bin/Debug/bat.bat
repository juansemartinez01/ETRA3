@echo off
Taskkill /f /im ETRA.exe
timeout /t 5 /nobreak > nul
:exit
start "" "C:\Program Files\MartinezPaezSoftware\ETRA\Setup.msi"
del "C:\Program Files\MartinezPaezSoftware\ETRA\Setup.msi"
cd "C:\Program Files\MartinezPaezSoftware\ETRA\"
start ETRA.exe
