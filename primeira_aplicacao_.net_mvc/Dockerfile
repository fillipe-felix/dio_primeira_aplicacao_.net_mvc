FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["primeira_aplicacao_.net_mvc/primeira_aplicacao_.net_mvc.csproj", "primeira_aplicacao_.net_mvc/"]
RUN dotnet restore "primeira_aplicacao_.net_mvc/primeira_aplicacao_.net_mvc.csproj"
COPY . .
WORKDIR "/src/primeira_aplicacao_.net_mvc"
RUN dotnet build "primeira_aplicacao_.net_mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "primeira_aplicacao_.net_mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "primeira_aplicacao_.net_mvc.dll"]
