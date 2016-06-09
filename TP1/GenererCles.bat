@echo off

cls

echo "generation du ficheir de cles"

set SN="C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\x64\sn.exe"

%SN% -k FCle.snk 

pause

