🔐 Week 5 – JWT Authentication & Kafka Integration (DotNet FSE Assignment)
This project demonstrates secure authentication using JWT (JSON Web Tokens) and event-driven architecture with Apache Kafka in a .NET Web API.

✅ Key Features:
🔑 User authentication with JWT

🔒 Secure API endpoints with role-based access

📨 Kafka integration for logging login events

🧪 Tested using curl for token-based authorization

📷 13 task-based screenshots included for validation

🛠️ Technologies Used:
.NET 8 Web API

JWT Bearer Authentication

Apache Kafka 3.9.1

Zookeeper

Confluent.Kafka NuGet package

PowerShell & curl for API testing

📁 Structure:
/Controllers/AuthController.cs – Handles login, JWT generation & Kafka publishing

/Program.cs – Configures services and authentication

appsettings.json – Contains JWT secrets

login.json – Sample login credentials used in API testing

🖼️ Screenshots:
01_Set_Variables.png to 13_Kafka_Message_Consumed.png