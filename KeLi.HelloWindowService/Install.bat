@echo off & color 17

if exist "%systemroot%\SysWOW64" path %path%;%windir%\SysNative;%systemroot%\SysWOW64;%~dp0
                
bcdedit > nul

if '%errorlevel%' neq '0' (goto uacprompt) else (goto uacadmin)

:uacprompt
%1 start "" mshta vbscript:createobject("shell.application").shellexecute("""%~0""","::",,"runas",1)(window.close) & exit
exit /b

:uacadmin
cd /d "%~dp0"

echo Current Path: "%cd%"
echo You are getting admin privileges.

:: Please insert your script...
installutil HelloWindowService.exe
net start TestService
sc config TestService start = auto