FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /app
EXPOSE 80

COPY . .
RUN dotnet restore 
RUN dotnet publish -c Release -o /app/published-app
RUN dotnet test

FROM mcr.microsoft.com/dotnet/sdk:7.0 as runtime
WORKDIR /app
COPY --from=build /app/published-app /app
ENTRYPOINT [ "dotnet", "/app/Engie.PowerPlants.Api.dll" ]
