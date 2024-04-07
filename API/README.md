# Trabajo-Final-2EVA

# Comandos-necesarios
    Comando para realizar un plan de migración:
    dotnet ef migrations add NombreDeLaMigracion -p Ruta/Al/Proyecto/Con/DbContext -s Ruta/Al/Proyecto/DeInicio
    dotnet ef migrations add NewCreate -p ./Teatro_dos_Facetas.Data/Teatro_dos_Facetas.Data.csproj -s ./Teatro_dos_Facetas.Api/Teatro_dos_Facetas.Api.csproj
    
    Update el plan de migración:
    dotnet ef database update  -p ./Teatro_dos_Facetas.Data/Teatro_dos_Facetas.Data.csproj -s ./Teatro_dos_Facetas.Api/Teatro_dos_Facetas.Api.csproj

    Lanzamineto Compose
    `docker-compose up --build --force-recreate -d`
    
# Comando para lanzar el proyecto
    dotnet sln add Teatro_dos_Facetas.Model

    dotnet new classlib -n Teatro_dos_Facetas.Data
    dotnet sln add Teatro_dos_Facetas.Data


    dotnet new classlib -n Teatro_dos_Facetas.Business
    dotnet sln add Teatro_dos_Facetas.Business

    dotnet new webapi -n Teatro_dos_Facetas.Api
    dotnet sln add Teatro_dos_Facetas.Api

    dotnet add Teatro_dos_Facetas.Api reference Teatro_dos_Facetas.Business
    dotnet add Teatro_dos_Facetas.Api reference Teatro_dos_Facetas.Data
    dotnet add Teatro_dos_Facetas.Api reference Teatro_dos_Facetas.Model

    dotnet add Teatro_dos_Facetas.Business reference Teatro_dos_Facetas.Data
    dotnet add Teatro_dos_Facetas.Business reference Teatro_dos_Facetas.Model

    dotnet add Teatro_dos_Facetas.Data reference Teatro_dos_Facetas.Model