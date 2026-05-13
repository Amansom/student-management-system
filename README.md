# Student Management System

A full-stack Student Management System built using ASP.NET Core Web API, Angular 17, SQL Server, JWT Authentication, and Layered Architecture.

---

# Project Overview

This project is developed to demonstrate:

* ASP.NET Core Web API development
* Angular frontend integration
* JWT Authentication
* SQL Server integration
* Layered Architecture
* CRUD operations
* Repository Pattern
* Exception Handling
* Swagger Documentation
* Serilog Logging

---

# Tech Stack Used

## Backend

* ASP.NET Core 8 Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* Serilog
* Swagger

## Frontend

* Angular 17+
* TypeScript
* Bootstrap 5
* Angular Standalone Components
* Route Guards
* HTTP Interceptors

## Database

* Microsoft SQL Server

---

# Project Architecture

```text
StudentManagementSystem
│
├── backend
│   ├── StudentManagementSystem.API
│   ├── StudentManagementSystem.Application
│   ├── StudentManagementSystem.Domain
│   ├── StudentManagementSystem.Infrastructure
│   └── StudentManagementSystem.Persistence
│
└── frontend
    └── student-management-ui
```

---

# Backend Layer Explanation

## 1. API Layer

Handles:

* Controllers
* Middleware
* JWT Authentication
* Swagger
* Dependency Injection
* API Endpoints

### Important Files

```text
Controllers/
Middleware/
Program.cs
appsettings.json
```

---

## 2. Application Layer

Contains:

* DTOs
* Interfaces
* Business Logic
* Services

### Responsibilities

* Validation
* Business rules
* Mapping entities to DTOs

---

## 3. Domain Layer

Contains:

* Core Entities

### Example

```text
Student.cs
```

Represents database table structure.

---

## 4. Persistence Layer

Handles:

* Entity Framework Core
* DbContext
* Repositories
* SQL Server operations

### Responsibilities

* Database communication
* CRUD operations
* Migrations

---

# Frontend Architecture

```text
src/app
│
├── components
│   ├── login
│   └── students
│
├── services
│   ├── auth.service.ts
│   └── student.service.ts
│
├── guards
├── interceptors
├── models
│
├── app.routes.ts
├── app.config.ts
└── app.component.ts
```

---

# End-to-End Flow Explanation

# 1. User Opens Angular Application

URL:

```text
http://localhost:4200
```

Angular loads:

```text
LoginComponent
```

using Angular Routing.

---

# 2. User Clicks Login

Angular calls:

```text
POST /api/auth/login
```

through:

```text
auth.service.ts
```

---

# 3. Backend Generates JWT Token

AuthController:

```text
api/auth/login
```

creates JWT token using:

* Secret Key
* Issuer
* Audience
* Claims

and returns:

```json
{
  "token": "jwt-token"
}
```

---

# 4. Angular Stores JWT Token

Token is stored inside:

```text
localStorage
```

---

# 5. Angular Navigates To Students Page

Angular route:

```text
/students
```

is protected using:

```text
auth.guard.ts
```

If token exists → access allowed.

---

# 6. HTTP Interceptor Automatically Adds JWT

Every API request automatically gets:

```text
Authorization: Bearer <token>
```

using:

```text
auth.interceptor.ts
```

---

# 7. Students CRUD Operations

Angular calls backend APIs:

| Method | API                |
| ------ | ------------------ |
| GET    | /api/students      |
| POST   | /api/students      |
| PUT    | /api/students/{id} |
| DELETE | /api/students/{id} |

---

# 8. Backend Flow

Controller → Service → Repository → Database

Example:

```text
StudentsController
    ↓
StudentService
    ↓
StudentRepository
    ↓
SQL Server Database
```

---

# 9. Repository Pattern

Repository handles:

* Add student
* Update student
* Delete student
* Get all students

using Entity Framework Core.

---

# 10. SQL Server Database

Database table:

```sql
Students
```

Columns:

| Column      | Type     |
| ----------- | -------- |
| Id          | int      |
| Name        | nvarchar |
| Email       | nvarchar |
| Age         | int      |
| Course      | nvarchar |
| CreatedDate | datetime |

---

# 11. Middleware

Global exception middleware catches:

* Runtime exceptions
* API errors
* Unexpected failures

and returns proper JSON response.

---

# 12. Swagger

Swagger automatically documents APIs.

URL:

```text
https://localhost:7149/swagger
```

---

# Security Features

* JWT Authentication
* Protected APIs
* Route Guards
* HTTP Interceptor
* CORS Configuration

---

# Features Implemented

## Backend

* JWT Authentication
* CRUD APIs
* SQL Server
* Layered Architecture
* Repository Pattern
* Swagger
* Exception Middleware
* Serilog Logging
* Entity Framework Core

## Frontend

* Angular Standalone Components
* Login Page
* Student CRUD UI
* Route Guards
* HTTP Interceptors
* Bootstrap UI
* API Integration

---

# API Endpoints

## Authentication

### Login

```http
POST /api/auth/login
```

---

## Students

### Get All Students

```http
GET /api/students
```

### Add Student

```http
POST /api/students
```

### Update Student

```http
PUT /api/students/{id}
```

### Delete Student

```http
DELETE /api/students/{id}
```

---

# Database Setup

# 1. Install SQL Server

Install:

* SQL Server
* SQL Server Management Studio (SSMS)

---

# 2. Update Connection String

Inside:

```text
appsettings.json
```

Update:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

# 3. Run Migrations

Open terminal inside:

```text
backend/StudentManagementSystem.API
```

Run:

```bash
dotnet ef migrations add InitialCreate --project ../StudentManagementSystem.Persistence --startup-project .
```

Then:

```bash
dotnet ef database update --project ../StudentManagementSystem.Persistence --startup-project .
```

---

# How To Run Backend

Navigate to:

```text
backend/StudentManagementSystem.API
```

Run:

```bash
dotnet run
```

Swagger URL:

```text
https://localhost:7149/swagger
```

---

# How To Run Frontend

Navigate to:

```text
frontend/student-management-ui
```

Install packages:

```bash
npm install
```

Run Angular:

```bash
ng serve
```

Frontend URL:

```text
http://localhost:4200
```


# Future Improvements

* Refresh Tokens
* Role-based Authentication
* Pagination
* Search & Filter
* Unit Testing
* Docker Support
* Angular Material UI
* AutoMapper
* FluentValidation
* CI/CD Pipeline

---

# Author

Aman Somvanshi

Software Engineer | .NET Full Stack Developer
