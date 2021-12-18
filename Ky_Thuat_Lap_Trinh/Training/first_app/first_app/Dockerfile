FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["first_app/first_app.csproj", "first_app/"]
RUN dotnet restore "first_app/first_app.csproj"
COPY . .
WORKDIR "/src/first_app"
RUN dotnet build "first_app.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "first_app.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "first_app.dll"]
