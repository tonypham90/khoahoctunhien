FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Practice.csproj", "./"]
RUN dotnet restore "Practice.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Practice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Practice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practice.dll"]
