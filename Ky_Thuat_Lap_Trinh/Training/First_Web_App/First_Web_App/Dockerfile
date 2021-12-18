FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["First_Web_App/First_Web_App.csproj", "First_Web_App/"]
RUN dotnet restore "First_Web_App/First_Web_App.csproj"
COPY . .
WORKDIR "/src/First_Web_App"
RUN dotnet build "First_Web_App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "First_Web_App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "First_Web_App.dll"]
