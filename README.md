# 🍽️ Recipe Manager

A web application built with **Blazor Web App (Server, .NET 8)** to manage cooking recipes in a simple and organized way.

🔗 [GitHub Repository](https://github.com/im-ThiagoC/RecipeManager)

---

## 🚀 Technologies Used

- [.NET 8.0](https://dotnet.microsoft.com/)
- [Blazor Web App (Server)](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)

---

## 📁 Solution Structure

```
RecipeManager.sln
│
├── DataAccess/                  # Data access project
│   ├── Data/                    # DbContext and database configuration
│   ├── Migrations/              # EF Core generated migrations
│   └── Models/                  # Entity model classes
│
├── RecipeManager/              # Main Blazor Server project
│   ├── wwwroot/                # Static files
│   ├── Components/             # Reusable components
│   │   ├── Layout/             # Application layouts
│   │   ├── Pages/              # Main pages
│   │   ├── App.razor
│   │   └── Routes.razor
│   ├── appsettings.json        # Application configuration
│   ├── Program.cs              # Application entry point
│   ├── README.md
│   └── LICENSE.txt
```

---

## 🔧 Project Setup

1. **Clone the repository**

```bash
git clone https://github.com/im-ThiagoC/RecipeManager.git
cd RecipeManager
```

2. **Configure the connection string in `appsettings.json`:**

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RecipeManager;Integrated Security=True"
}
```

3. **Apply the migrations**

```bash
# In the Package Manager Console:
Update-Database
```

---

## ✅ Features

- Create, edit, and delete recipes  
- View recipe list  
- Organized using reusable components  
- Separated data access layer (DataAccess)

---

## 🛠️ In Development

- [ ] Image upload
- [ ] Recipe search
- [ ] User authentication
- [ ] Recipe sharing

---

## 🤝 Contribute!

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

---

## 📄 License

Distributed under the MIT License. See `LICENSE.txt` for more information.

---

Made with 💙 by [ThiagoC](https://github.com/im-ThiagoC)
