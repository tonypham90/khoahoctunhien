FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Practive_KTLT/Practive_KTLT.csproj", "Practive_KTLT/"]
RUN dotnet restore "Practive_KTLT/Practive_KTLT.csproj"
COPY . .
WORKDIR "/src/Practive_KTLT"
RUN dotnet build "Practive_KTLT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Practive_KTLT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practive_KTLT.dll"]
