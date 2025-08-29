@echo off

echo ----------------------------------
echo Limpiando...
if exist bin (
    rmdir /s /q bin
) else (
    echo All Clean
)
if exist obj (
    rmdir /s /q obj
) else (
    echo All Clean
)
echo ----------------------------------
echo Clean Completed
echo ----------------------------------