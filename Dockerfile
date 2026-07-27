# ---------------------------------------------------
# Etapa 1: Build (Usando o SDK do .NET 10)
# ---------------------------------------------------
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copia e restaura o arquivo de projeto (.csproj) primeiro para aproveitar o cache de camadas
COPY ["GerenciadorDeBiblioteca.csproj", "./"]
RUN dotnet restore "GerenciadorDeBiblioteca.csproj"

# Copia o restante do código e compila a aplicação
COPY . .
RUN dotnet publish "GerenciadorDeBiblioteca.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ---------------------------------------------------
# Etapa 2: Runtime (Imagem leve para execução)
# ---------------------------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

# Variável de ambiente padrão do ASP.NET Core no .NET 10 (Porta 8080)
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Copia os artefatos compilados da etapa de build
COPY --from=build /app/publish .

# Comando de entrada da sua aplicação
ENTRYPOINT ["dotnet", "GerenciadorDeBiblioteca.dll"]