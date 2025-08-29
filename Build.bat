@echo off

echo ----------------------------------
set PATH=compilation/dotnet

dotnet clean

if exist bin (
    rmdir /s /q bin
)
if exist obj (
    rmdir /s /q obj
)

dotnet build
echo ----------------------------------
set PATH=compilation/mingw64/bin
g++ -static source/engine/main.cpp -o bin/Debug/net8.0-windows/win-x64/main.exe
echo Build complete.

set /p answer=Run the Editor? (y/n):
if /i "%answer%"=="y" (
    echo ----------------------------------
    echo Run...
    start "" "bin\Debug\net8.0-windows\win-x64\Sonic Editor.exe"
) else (
    echo Cancel...
    exit /b
)
echo ----------------------------------
pause   