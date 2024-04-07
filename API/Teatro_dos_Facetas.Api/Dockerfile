FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY * .
COPY Teatro_dos_Facetas.Api/*.csproj ./Teatro_dos_Facetas.Api/
COPY Teatro_dos_Facetas.Business/*.csproj ./Teatro_dos_Facetas.Business/
COPY Teatro_dos_Facetas.Data/*.csproj ./Teatro_dos_Facetas.Data/
COPY Teatro_dos_facetas.Model/Teatro_dos_facetas.Model.csproj ./Teatro_dos_facetas.Model/

RUN dotnet restore Teatro_dos_facetas.sln




COPY . .

RUN dotnet publish Teatro_dos_facetas.sln -c Release -o Api/out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/Api/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "Teatro_dos_Facetas.Api.dll"]