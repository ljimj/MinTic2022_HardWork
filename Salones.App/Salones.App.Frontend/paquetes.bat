@echo off
echo.
echo INSTALADOR DE PAQUETES  -  DOT NET CORE 5.0
echo.
echo Este programa instala automaticamente los paquetes necesarios.
echo Solo debería ejecutarse una vez.
echo.
echo No funciona bien en la consola Powershell del VSCode, debería 
echo ejecutarse desde la consola de windows.
echo
echo on

dotnet tool install -g dotnet-aspnet-codegenerator --version="3.1" 

dotnet tool update --global dotnet-aspnet-codegenerator

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.9

dotnet add package Microsoft.AspNetCore.Identity.UI --version 5.0.9

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
