FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Bai_Tap/Bai_Tap.csproj", "Bai_Tap/"]
RUN dotnet restore "Bai_Tap/Bai_Tap.csproj"
COPY . .
WORKDIR "/src/Bai_Tap"
RUN dotnet build "Bai_Tap.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bai_Tap.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bai_Tap.dll"]
