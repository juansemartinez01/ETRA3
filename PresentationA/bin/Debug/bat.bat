@echo off
Taskkill /f /im ETRA.exe
:exit
msiexec.exe /i "C:\Program Files\MartinezPaezSoftware\ETRA\Setup.msi" /qn
del "C:\Program Files\MartinezPaezSoftware\ETRA\Setup.msi"
cd "C:\Program Files\MartinezPaezSoftware\ETRA\"
start ETRA.exe
