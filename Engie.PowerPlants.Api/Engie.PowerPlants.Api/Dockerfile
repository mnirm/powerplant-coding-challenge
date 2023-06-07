FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Engie.PowerPlants.Api/Engie.PowerPlants.Api.csproj", "Engie.PowerPlants.Api/"]
RUN dotnet restore "Engie.PowerPlants.Api/Engie.PowerPlants.Api.csproj"
COPY . .
WORKDIR "/src/Engie.PowerPlants.Api"
RUN dotnet build "Engie.PowerPlants.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Engie.PowerPlants.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Engie.PowerPlants.Api.dll"]
