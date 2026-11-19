@echo off
rem Builds the app without Visual Studio, using the C# compiler that ships with Windows (.NET Framework 4.8).
rem Output: bin\Release\hotelseabeach.exe (+ hotelseabeach.exe.config)

setlocal
cd /d "%~dp0"
set CSC=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\csc.exe
if not exist "%CSC%" set CSC=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\csc.exe
if not exist bin\Release mkdir bin\Release

"%CSC%" -nologo -target:winexe -optimize+ -out:bin\Release\hotelseabeach.exe ^
  -r:System.dll -r:System.Core.dll -r:System.Data.dll -r:System.Drawing.dll ^
  -r:System.Windows.Forms.dll -r:System.Configuration.dll -r:System.Xml.dll ^
  *.cs Properties\*.cs
if errorlevel 1 (
  echo Build failed.
  exit /b 1
)

copy /y App.config bin\Release\hotelseabeach.exe.config >nul
echo Built bin\Release\hotelseabeach.exe
