# Blazor CRUD Application

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-6.0-blue.svg)
![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-blue.svg)

## 📖 Descrição

Este projeto é uma aplicação CRUD (Create, Read, Update, Delete) desenvolvida com **Blazor WebAssembly** e **ASP.NET Core**. Ele permite gerenciar categorias, fornecendo uma interface amigável para criar, visualizar, editar e excluir registros.

## 🚀 Funcionalidades

- **Criar** novas categorias
- **Visualizar** lista de categorias
- **Atualizar** informações das categorias existentes
- **Excluir** categorias
- Validação de formulários
- Interface responsiva e intuitiva

## 🛠️ Tecnologias Utilizadas

- [**Blazor WebAssembly**](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) - Framework para construção de interfaces web interativas usando C# em vez de JavaScript.
- [**ASP.NET Core**](https://dotnet.microsoft.com/apps/aspnet) - Framework web de código aberto e multiplataforma da Microsoft.
- [**Entity Framework Core**](https://docs.microsoft.com/ef/core/) - ORM (Object-Relational Mapper) para acesso a dados.
- [**Bootstrap**](https://getbootstrap.com/) - Biblioteca CSS para estilização responsiva.
- [**Umbler Style Guide**](https://styleguide.umbler.com/) - Guia de estilos para consistência visual.

## 📦 Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado no seu sistema:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- [Node.js e npm](https://nodejs.org/) (para gerenciar pacotes frontend, se necessário)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) (opcional, mas recomendado)

## 🛠️ Instalação

### 1. Clone o Repositório

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio

2. Configurar o Banco de Dados
Este projeto usa um banco de dados em memória para simplificação. Para persistência real, configure o AppDbContext no Program.cs com o provedor de banco de dados desejado (ex: SQL Server, SQLite).

3. Restaurar Pacotes
Restaure os pacotes NuGet e npm (se aplicável):
dotnet restore
npm install
