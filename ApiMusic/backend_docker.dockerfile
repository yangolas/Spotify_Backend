#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 7250

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiMusic/ApiMusic.csproj", "ApiMusic/"]
COPY ["Commons/Commons.csproj", "Commons/"]
COPY ["Infraestructure/Infraestructure.csproj", "Infraestructure/"]
COPY ["RabbitMQ/RabbitMQ.csproj", "RabbitMQ/"]
RUN dotnet restore "ApiMusic/ApiMusic.csproj"
COPY . .
WORKDIR "/src/ApiMusic"
RUN dotnet build "ApiMusic.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiMusic.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:7250
ENTRYPOINT ["dotnet", "ApiMusic.dll"]