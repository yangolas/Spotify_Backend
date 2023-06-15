ARG project_path=${HOME}/Desktop/DockerBack
# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Copiar los archivos de cada proyecto individualmente y restaurar dependencias

# Copiar los archivos de Commons
WORKDIR /src/Commons
COPY ${project_path}/Commons/Commons.csproj .
RUN dotnet restore

# Copiar los archivos de RabbitMQ
WORKDIR /src/RabbitMQ
COPY ${project_path}/RabbitMQ/RabbitMQ.csproj .
RUN dotnet restore

# Copiar los archivos de Infraestructure
WORKDIR /src/Infraestructure
COPY ${project_path}/Infraestructure/Infraestructure.csproj .
RUN dotnet restore

# Copiar los archivos de ApiMusic
WORKDIR /src/ApiMusic
COPY ${project_path}/ApiMusic/ApiMusic.csproj .
RUN dotnet restore

# Construir cada proyecto individualmente
WORKDIR /src/Commons
RUN dotnet build -c Debug -o /src/Commons

WORKDIR /src/RabbitMQ
RUN dotnet build -c Debug -o /src/RabbitMQ

WORKDIR /src/Infraestructure
RUN dotnet build -c Debug -o /src/Infraestructure

WORKDIR /src/ApiMusic
RUN dotnet build -c Debug -o /src/ApiMusic


# Etapa final de producción
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Copiar los archivos generados de cada proyecto
WORKDIR /src
COPY --from=build-env /src .

# Configurar el punto de entrada y los comandos necesarios para cada proyecto
WORKDIR /app/ApiMusic
ENTRYPOINT ["dotnet", "ApiMusic.dll"]
