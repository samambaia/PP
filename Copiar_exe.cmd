echo off
cls
rem Fazendo Backup
copy \\geraes1\C\Geraes\Geraes.Net\Bin\Release\*.* \\geraes1\C\Geraes\Geraes.Net\binbackup\Release
rem Atualizando o Executavel...
c:
cd\Geraes\Geraes.Net\bin\Release

rem GERAES1
copy *.* \\geraes1\Geraes.net\bin\release

REM GERAES3
copy *.* \\geraes3\Geraes.net\bin\release

REM NOTEBOOK
copy *.* \\hppavilion\Geraes\Geraes.Net\bin\Release


rem Atualizado com sucesso!!!
pause
cd\
