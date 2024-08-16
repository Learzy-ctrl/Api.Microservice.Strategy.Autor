# Establecer la imagen base para el SDK de .NET
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar el archivo .csproj y restaurar las dependencias
COPY Api.Microservice.Strategy.Autor/*.csproj ./Api.Microservice.Strategy.Autor/
RUN dotnet restore Api.Microservice.Strategy.Autor/Api.Microservice.Strategy.Autor.csproj

# Copiar el resto de los archivos y construir la aplicación
COPY Api.Microservice.Strategy.Autor/ ./Api.Microservice.Strategy.Autor/
WORKDIR /app/Api.Microservice.Strategy.Autor
RUN dotnet build -c Release -o /app/build

# Establecer la imagen base para el runtime de .NET
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos de la compilación desde el contenedor anterior
COPY --from=build-env /app/build .

# Exponer el puerto y ejecutar la aplicación
EXPOSE 80
ENTRYPOINT ["dotnet", "Api.Microservice.Strategy.Autor.dll"]

