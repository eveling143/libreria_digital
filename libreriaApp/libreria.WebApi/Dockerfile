FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./", "libreria.WebApi/"]
RUN dotnet restore "libreria.WebApi/libreria.WebApi.csproj" 
COPY . .
WORKDIR "/src/libreria.WebApi"
RUN dotnet build "libreria.WebApi.csproj" -c Release -o /app/build

FROM build AS publish 
RUN dotnet publish "libreria.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final 
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "libreria.WebApi.dll"]