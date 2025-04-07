# 🍽️ Recipe Manager

Um aplicativo web feito com **Blazor Web App (.NET 8)** para gerenciar receitas culinárias. Ideal para quem quer organizar, buscar e armazenar receitas em um só lugar.

🔗 [Acesse o repositório no GitHub](https://github.com/im-ThiagoC/RecipeManager)

---

## 🚀 Tecnologias Utilizadas

- [.NET 8.0](https://dotnet.microsoft.com/)
- [Blazor Web App (Server)](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- Arquitetura separada com:
  - Projeto principal: `RecipeManager`
  - Camada de dados: `DataAccess`

---

## 📦 Estrutura do Projeto

```
RecipeManager/
│
├── DataAccess/              # Camada de acesso a dados (DbContext, Migrations)
│   └── Migrations/
│
├── Pages/                   # Páginas do Blazor
│
├── wwwroot/                 # Arquivos estáticos (CSS, JS, etc.)
│
├── appsettings.json         # Configuração da connection string
│
└── Program.cs               # Configuração inicial da aplicação
```

---

## 🔧 Configuração

1. **Clone o repositório:**

```bash
git clone https://github.com/im-ThiagoC/RecipeManager.git
cd RecipeManager
```

2. **Configure o banco de dados no `appsettings.json`:**

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RecipeManager;Integrated Security=True"
}
```

3. **Crie o banco e aplique as migrations:**

```bash
# No terminal ou no Package Manager Console:
Update-Database
```

---

## 🧪 Funcionalidades

- 📋 Cadastro e edição de receitas
- 🔍 Filtro por nome, ingredientes ou categorias
- 📁 Armazenamento local com SQL Server LocalDB
- 💡 Interface leve e responsiva com Blazor Server

---

## 🛠️ Em desenvolvimento

- [ ] Upload de imagens para cada receita
- [ ] Login e autenticação
- [ ] Compartilhamento de receitas públicas

---

## 🤝 Contribuindo

Contribuições são bem-vindas! Abra uma issue ou envie um Pull Request 😊

---

## 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

> Feito com 💙 usando Blazor e .NET 8 — por [ThiagoC](https://github.com/im-ThiagoC)
