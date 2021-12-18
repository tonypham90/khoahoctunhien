FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Mot_Loi_Chao/Mot_Loi_Chao.csproj", "Mot_Loi_Chao/"]
RUN dotnet restore "Mot_Loi_Chao/Mot_Loi_Chao.csproj"
COPY . .
WORKDIR "/src/Mot_Loi_Chao"
RUN dotnet build "Mot_Loi_Chao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mot_Loi_Chao.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mot_Loi_Chao.dll"]
