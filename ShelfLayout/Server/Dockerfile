FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShelfLayout/Server/ShelfLayout.Server.csproj", "ShelfLayout/Server/"]
COPY ["ShelfLayout/Client/ShelfLayout.Client.csproj", "ShelfLayout/Client/"]
COPY ["ShelfLayout/Shared/ShelfLayout.Shared.csproj", "ShelfLayout/Shared/"]
RUN dotnet restore "ShelfLayout/Server/ShelfLayout.Server.csproj"
COPY . .
WORKDIR "/src/ShelfLayout/Server"
RUN dotnet build "ShelfLayout.Server.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "ShelfLayout.Server.csproj" -c Debug -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShelfLayout.Server.dll"]