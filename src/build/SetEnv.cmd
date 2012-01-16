@ECHO OFF
:: -------------------------------------------------------------------
:: Abstract: This batch file sets the appropriate environment variables
::   for the build environment.
::
:: Usage : SetEnv [options]
:: Sample: SetEnv /x86 /release /2003
::
:: Note : Variables delayed expansion must have been enabled !
::
:: -------------------------------------------------------------------



IF "%WindowsSdkVersion%"=="" (
  CALL :SetWindowsSdkVersionHelper HKCU > nul 2>&1
  IF ERRORLEVEL 1 CALL :SetWindowsSdkVersionHelper HKLM > nul 2>&1
  IF ERRORLEVEL 1 GOTO ERROR_NOWSDK
)

CALL :SetWindowsSdkPathHelper > nul 2>&1
IF ERRORLEVEL 1 GOTO ERROR_NOWSDK

IF EXIST "%WindowsSdkPath%Bin\SetEnv.cmd" (
  CALL "%WindowsSdkPath%Bin\SetEnv.cmd" %* > nul
  COLOR
) ELSE IF "%WindowsSdkVersion%"=="v7.0A" (
  IF EXIST "%VS100COMNTOOLS%vsvars32.bat" (
    CALL "%VS100COMNTOOLS%vsvars32.bat" > nul
    GOTO END
  )
  GOTO ERROR_NOWSDK
) ELSE IF "%WindowsSdkVersion%"=="v6.0A" (
  IF EXIST "%VS90COMNTOOLS%vsvars32.bat" (
    CALL "%VS90COMNTOOLS%vsvars32.bat" > nul
    GOTO END
  )
  IF EXIST "%VS80COMNTOOLS%vsvars32.bat" (
    CALL "%VS80COMNTOOLS%vsvars32.bat" > nul
    GOTO END
  )
  GOTO ERROR_NOWSDK
) ELSE (
  EXIT /B 1
)
GOTO END

:SetWindowsSdkPathHelper
SET WindowsSdkPath=
FOR /F "tokens=1,2*" %%i in ('REG QUERY "HKLM\SOFTWARE\Microsoft\Microsoft SDKs\Windows\%WindowsSdkVersion%" /V InstallationFolder') DO (
    IF "%%i"=="InstallationFolder" (
        SET "WindowsSdkPath=%%k"
    )
)
IF "%WindowsSdkPath%"=="" EXIT /B 1
EXIT /B 0

:SetWindowsSdkVersion
CALL :GetWindowsSdkVersionHelper HKCU > nul 2>&1
IF ERRORLEVEL 1 CALL :GetWindowsSdkVersionHelper HKLM > nul 2>&1
IF ERRORLEVEL 1 EXIT /B 1
EXIT /B 0

:SetWindowsSdkVersionHelper
SET WindowsSdkVersion=
FOR /F "tokens=1,2*" %%i in ('REG QUERY "%1\SOFTWARE\Microsoft\Microsoft SDKs\Windows" /V CurrentVersion') DO (
    IF "%%i"=="CurrentVersion" (
        SET "WindowsSdkVersion=%%k"
    )
)
IF "%WindowsSdkVersion%"=="" EXIT /B 1
EXIT /B 0

:ERROR_EXT
ECHO Could not activate command extensions. 1>&2
EXIT /B 1

:ERROR_NOWSDK
ECHO The Windows SDK %WindowsSdkVersion% could not be found. 1>&2
EXIT /B 1



:: -------------------------------------------------------------------
:: End
:: -------------------------------------------------------------------
:END