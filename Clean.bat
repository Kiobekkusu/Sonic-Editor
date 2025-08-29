@echo off

echo ----------------------------------
echo Limpiando...
if exist bin (
    rmdir /s /q bin
) else (
    echo Todo limpio
)
if exist obj (
    rmdir /s /q obj
) else (
    echo Todo limpio
)
echo ----------------------------------
echo Clean Completed
echo ----------------------------------