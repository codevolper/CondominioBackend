# CondominioBackend

## GerenciaUsuario

Sistema de gerenciamento de usuários com arquitetura limpa, persistência em SQL Server via Docker e Entity Framework Core.

### 🚀 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/)
- [ASP.NET Core Web API](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/ef/core)
- [SQL Server 2022 (Docker)](https://hub.docker.com/_/microsoft-mssql-server)
- [Docker Compose](https://docs.docker.com/compose/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [C#](https://learn.microsoft.com/dotnet/csharp/)

---

### 🧱 Estrutura do Projeto

```plaintext
GerenciaUsuario/
├── src/
│   ├── GerenciaUsuario.API/           # Camada de apresentação (Web API)
│   ├── GerenciaUsuario.Application/   # Regras de negócio e interfaces
│   ├── GerenciaUsuario.Domain/        # Entidades e enums
│   └── GerenciaUsuario.Infrastructure/ # Persistência e DbContext
├── sql/
│   └── init.sql                       # Script de criação de banco e tabelas
├── docker-compose.yml                # Orquestração do SQL Server
└── README.md
```

### Migrations e EF Core

```Criar Migration
dotnet ef migrations add Inicial
```
```Atualizar banco
dotnet ef database update
```

### 🧪 Teste rápido da API
```
POST /api/usuarios
Content-Type: application/json

{
  "nome": "Nome Usuario",
  "cpf": "12345678900",
  "telefone": "21999999999",
  "email": "usuario@email.com",
  "senha": "123456",
  "tipoUsuario": 3,
  "endereco": {
    "logradouro": "Rua A",
    "numero": "123",
    "bairro": "Centro",
    "cidade": "Rio de Janeiro",
    "estado": "RJ",
    "cep": "20000000"
  }
}
```

📌 Requisitos
Docker Desktop

.NET SDK 8.0+

VS Code com extensão C# e SQL Server

📚 Próximos passos
Implementar autenticação JWT

Criar testes unitários com xUnit

Adicionar Swagger para documentação da API

Configurar CI/CD com GitHub Actions

🧑‍💻 Autor
Leonardo Rio de Janeiro, Brasil Desenvolvedor .NET apaixonado por arquitetura limpa e automação com Docker.
