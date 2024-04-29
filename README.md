# Bootcamp .NET Developer 2024

## Como um projeto .NET é organizado?
De forma simplicada um projeto .NET é estruturado da seguinte maneira:

- **Solution File (.sln)** - Esse arquivo contém um ou mais projetos .NET relacionados. 
- **Projetos** - Cada projeto referênciado por uma solution é uma unidade independente que compõe a aplicação. Alguns exemplos de aplicações .NET são: Class Library (classes e recursos reutilizáveis), Console Application (um app de console), ASP.NET Core Web Application (aplicativos web), Unit Test Projects (testes unitários), Blazor Application.
- **Arquivos de Build e Configuração** - Arquivos como *.csproj para projetos .NET Core/.NET Standard ou *.csproj e *.sln para projetos .NET Framework.


## Comandos importantes
```bash
dotnet new console # cria uma aplicação dotnet que possui interação através do console
dotnet run # executa um projeto dotnet (esse comando sempre procura um arquivo .csproj no diretório corrente).
```
