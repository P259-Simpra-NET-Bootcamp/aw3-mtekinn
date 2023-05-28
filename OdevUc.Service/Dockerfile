FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OdevUc.Service/OdevUc.Service.csproj", "OdevUc.Service/"]
RUN dotnet restore "OdevUc.Service/OdevUc.Service.csproj"
COPY . .
WORKDIR "/src/OdevUc.Service"
RUN dotnet build "OdevUc.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OdevUc.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OdevUc.Service.dll"]
