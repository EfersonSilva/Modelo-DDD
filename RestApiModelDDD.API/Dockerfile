#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["RestApiModelDDD.API/RestApiModelDDD.API.csproj", "RestApiModelDDD.API/"]
RUN dotnet restore "RestApiModelDDD.API/RestApiModelDDD.API.csproj"
COPY . .
WORKDIR "/src/RestApiModelDDD.API"
RUN dotnet build "RestApiModelDDD.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestApiModelDDD.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestApiModelDDD.API.dll"]