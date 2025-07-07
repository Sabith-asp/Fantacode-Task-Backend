# 🛠️ Backend - Machine Task API (ASP.NET Core 8)

This is the backend of the **Machine Task** project built using **ASP.NET Core Web API (.NET 8)**. It includes authentication, bar and pie chart data APIs, structured layers (Controllers, Services, Repositories), and a clean architecture.

---

## 🚀 Tech Stack

- **Language**: C#  
- **Framework**: .NET 8 (ASP.NET Core Web API)  
- **API Docs**: Swagger  
- **Architecture**: Clean layered architecture  
- **Port**: `https://localhost:7121`  

---

---

## ⚙️ Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/Sabith-asp/Fantacode-Task-Backend.git
cd MachineTask-Fantacode-Backend/Backend

2. Restore Dependencies
dotnet restore

3. Run Redis using Docker (Required for Rate Limiting)
docker run -d --name redis-ratelimit -p 6379:6379 redis

4. Run the Application
dotnet run

https://localhost:7121

🔐 Sample Login Credentials
Username: ameen123  
Password: Ameen@123
