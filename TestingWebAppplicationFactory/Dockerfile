FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestingWebAppplicationFactory/TestingWebAppplicationFactory.csproj", "TestingWebAppplicationFactory/"]
RUN dotnet restore "TestingWebAppplicationFactory/TestingWebAppplicationFactory.csproj"
COPY . .
WORKDIR "/src/TestingWebAppplicationFactory"
RUN dotnet build "TestingWebAppplicationFactory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestingWebAppplicationFactory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestingWebAppplicationFactory.dll"]
