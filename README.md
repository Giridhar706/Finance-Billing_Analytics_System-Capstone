# Finance Billing Analytics

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?logo=.net&logoColor=white&style=for-the-badge" alt=".NET 8.0" />
  <img src="https://img.shields.io/badge/SQL_Server-LocalDB-CC2927?logo=microsoft-sql-server&logoColor=white&style=for-the-badge" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Entity_Framework-Core_8-512BD4?style=for-the-badge" alt="EF Core" />
  <img src="https://img.shields.io/badge/Docker-Supported-2496ED?logo=docker&logoColor=white&style=for-the-badge" alt="Docker" />
  <img src="https://img.shields.io/badge/CI%2FCD-GitHub_Actions_%26_Azure-2088FF?logo=github-actions&logoColor=white&style=for-the-badge" alt="CI/CD" />
</p>

<p align="center">
  <b>Wipro NGA Training Program — Capstone Project</b><br />
  Designed and Developed by: <b>Giridhar Gopal</b> (GitHub: <a href="https://github.com/Giridhar706">Giridhar706</a>)
</p>

---

## 🌟 Overview

Finance Billing Analytics is a secure ASP.NET Core-based Finance & Billing Platform designed to manage invoices, payments, revenue tracking, and audit activities. The application helps organizations reduce revenue leakage through secure financial operations, reporting, and analytics.

This solution demonstrates the implementation of ASP.NET Core MVC, ASP.NET Core Web API, Entity Framework Core, ADO.NET, SQL Server, JWT Authentication, Role-Based Authorization, Unit Testing, Docker, GitHub Actions, and Azure deployment concepts.

---

# 🎯 Business Objective

Reduce revenue leakage by providing a secure platform for:

* Invoice Management
* Payment Tracking
* Revenue Analytics
* Audit Logging
* Secure Financial Operations

---

# 🛠️ Technology Stack

## 💻 Backend

* ASP.NET Core MVC
* ASP.NET Core Web API
* C#
* Entity Framework Core
* ADO.NET

## 🗃️ Database

* Microsoft SQL Server
* Stored Procedures
* Triggers
* SQL Scripts

## 🔐 Security

* JWT Authentication
* Role-Based Authorization

## 🧪 Testing

* xUnit
* Moq

## 🚀 DevOps

* Docker
* GitHub Actions

## ☁️ Cloud

* Azure App Service (Conceptual)
* Azure SQL Database (Conceptual)

## 🤖 AI Modernization

* GitHub Copilot
* MCP AI Agent Concept

---

# 📂 Solution Structure

```text
FinanceBillingAnalytics
│
├── FinanceBillingAnalytics
│   ├── Controllers
│   ├── Models
│   ├── Services
│   ├── Repositories
│   ├── Views
│   └── Data
│
├── FinanceBillingAnalytics.API
│   ├── Controllers
│   ├── Models
│   ├── Services
│   └── Data
│
├── FinanceBillingAnalytics.Tests
│
├── Documentation
│
├── Database
│
├── Dockerfile
│
└── README.md
```

---

# ✨ Core Features

## 🧾 Invoice Management

* Create Invoice
* Update Invoice
* Delete Invoice
* View Invoice Details

## 💳 Payment Management

* Record Payments
* Update Payments
* Delete Payments
* View Payment History

## 📊 Revenue Analytics

* Revenue Summary Dashboard
* Stored Procedure Reporting
* ADO.NET Analytics Integration

## 📝 Audit Logging

* Financial Activity Tracking
* User Action Monitoring

---

# Security Features

## 🔐 JWT Authentication

Secure token-based authentication is implemented for API access.

## 🛡️ Role-Based Authorization

Admin users can:

* Create Invoices
* Update Invoices
* Delete Invoices
* Create Payments
* Update Payments
* Delete Payments

Authenticated users can:

* View Invoice Data
* View Payment Data

---

# 🗄️ Database Design

## 📋 Tables

* Users
* Invoices
* Payments
* AuditLogs

## ⚙️ Stored Procedures

* sp_GetRevenueSummary
* sp_GetPaidInvoices
* sp_GetPaymentDetails

## 🔄 Triggers

* ⚡ trg_UpdateInvoiceStatus

Automatically updates Invoice Status to Paid after payment insertion.

---

# 📡  Data Access Strategy

## 🗄️  Entity Framework Core

Used for:

* CRUD Operations
* Entity Mapping
* Database Access

## 📊  ADO.NET

Used for:

* Revenue Analytics
* Stored Procedure Execution
* Reporting

---

# 🧪 Testing

Unit Testing is implemented using:

* xUnit
* Moq

Covered Areas:

* Invoice Service
* Payment Service
* Validation Logic
* Business Rules

---

# 🔌 API Endpoints

## 🔐 Authentication

```http
POST /api/Auth/login
```

## 🧾 Invoice APIs

```http
GET    /api/Invoice
GET    /api/Invoice/{id}
POST   /api/Invoice
PUT    /api/Invoice/{id}
DELETE /api/Invoice/{id}
```

## 💳  Payment APIs

```http
GET    /api/Payment
GET    /api/Payment/{id}
POST   /api/Payment
PUT    /api/Payment/{id}
DELETE /api/Payment/{id}
```

---

# 🚀 DevOps Strategy

## 🐳 Docker

Application containerization is implemented using Docker.

## 🔄 GitHub Actions

CI/CD pipeline stages:

1. Restore
2. Build
3. Test
4. Publish

---

# ☁️ Azure Deployment Architecture (Conceptual)

```text
Developer
    ↓
GitHub Repository
    ↓
GitHub Actions
    ↓
Docker Container
    ↓
Azure App Service
    ↓
Azure SQL Database
```

Future deployment can be performed using Azure App Service and Azure SQL Database.

---

# 🤖 AI Modernization

## ✨ GitHub Copilot

Used for:

* Repository Generation
* Unit Test Generation
* Boilerplate Code Assistance

## 🧠 MCP AI Agent Concept

Future enhancement:

* Ticket Summarization
* Invoice Query Assistance
* Payment Insights

---

# 📚 Documentation

Project documentation is available in the Documentation folder.

Included Documents:

* Architecture Diagram
* Business Rules
* API Documentation
* Azure Deployment Strategy
* MCP Concept
* Copilot Prompt Log

---

# 🗺️ User Story Mapping

## 🎯 US1 – US2

Backend & Core Business Rules

* OOP
* SOLID Principles
* Exception Handling
* Unit Testing

## 🗄️ US3 – US4

Database & Data Access

* SQL Design
* Stored Procedures
* Triggers
* ADO.NET
* EF Core

## 🌐 US5 – US7

Web Application

* ASP.NET Core MVC
* Razor Views
* AJAX
* Validation
* Routing

## 🔐 US8 – US9

Web API & Security

* REST APIs
* JWT Authentication
* Role-Based Authorization

## ☁️ US10 – US11

Cloud & DevOps

* Docker
* GitHub Actions
* Azure Deployment Architecture

## 🤖 US12

AI Modernization

* GitHub Copilot
* MCP AI Agent Concept

## 📚  US13

Documentation & Submission Assets

* Architecture Diagram
* API Documentation
* Business Rules
* Deployment Strategy

---

# 👨‍💻 Author

Giridhar Gopal

🏆 Finance Billing Analytics Capstone Project
