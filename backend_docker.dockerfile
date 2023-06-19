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

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY openssl.cnf /app/openssl.cnf

RUN apt-get update && apt-get install -y openssl

RUN openssl req -new -newkey rsa:2048 -days 365 -nodes -x509 \
    -subj "/C=US/ST=State/L=City/O=Organization/CN=localhost" \
    -keyout /app/cert.key -out /app/cert.crt \
    -config /app/openssl.cnf

RUN openssl pkcs12 -export -out /app/cert.pfx -inkey /app/cert.key -in /app/cert.crt -password pass:spotify

RUN rm /app/cert.crt /app/cert.key

# Establecer la variable de entorno ASPNETCORE_ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT=Docker
ENV ASPNETCORE_URLS=https://localhost:7252/api/section

ENTRYPOINT ["dotnet", "ApiMusic.dll"]
