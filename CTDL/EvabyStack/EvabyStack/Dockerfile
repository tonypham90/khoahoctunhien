FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EvabyStack/EvabyStack.csproj", "EvabyStack/"]
RUN dotnet restore "EvabyStack/EvabyStack.csproj"
COPY . .
WORKDIR "/src/EvabyStack"
RUN dotnet build "EvabyStack.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EvabyStack.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EvabyStack.dll"]
