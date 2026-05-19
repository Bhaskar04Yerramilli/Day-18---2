# Advanced MVC Filters Applications

The projects demonstrate the implementation of Advanced MVC Filters for handling:
- Authentication
- Authorization
- Logging
- Exception Handling
- Dependency Injection
- Security Management

---

# Projects Included

## 1. E-Commerce Platform with Advanced MVC Filters

An ASP.NET Core MVC application designed to demonstrate the use of custom MVC filters for handling common cross-cutting concerns in an e-commerce system.

### Features
- Authentication Filter
- Logging Filter
- Global Exception Filter
- Dependency Injection
- Error Handling
- MVC Architecture

### Functionalities
- Logs HTTP requests and responses
- Restricts unauthorized access to protected pages
- Handles exceptions globally
- Displays user-friendly error pages
- Uses Dependency Injection for services and filters

---

## 2. Online Banking Application with Advanced MVC Filters

An ASP.NET Core MVC application developed to demonstrate advanced filter implementation for security, logging, and error management in an online banking environment.

### Features
- Authentication Filter
- Authorization Filter
- Logging Filter
- Global Exception Handling
- Role-Based Access Control
- Dependency Injection

### Functionalities
- Validates user authentication
- Restricts access based on user roles
- Logs user activities and actions
- Handles application exceptions globally
- Provides secure access to banking operations

---

# Technologies Used

- ASP.NET Core MVC
- C#
- .NET 8
- Visual Studio 2026

---

# MVC Filters Implemented

## Authentication Filter
Ensures that users are authenticated before accessing protected resources.

## Authorization Filter
Restricts access to specific users or roles.

## Logging Filter
Logs request details, response status codes, and user activities.

## Exception Filter
Handles unhandled exceptions globally and displays friendly error pages.

---

# Dependency Injection

Both projects use ASP.NET Core Dependency Injection for:
- Service management
- Filter injection
- Better modularity and maintainability

---

# Project Structure

## ECommerceFiltersApp

```text
ECommerceFiltersApp/
│
├── Controllers/
├── Filters/
├── Services/
├── Models/
├── Views/
└── Program.cs
```

### Filters Included
- AuthFilter
- LoggingFilter
- GlobalExceptionFilter

### Services Included
- AuthService
- LoggingService

---

## BankingFiltersApp

```text
BankingFiltersApp/
│
├── Controllers/
├── Filters/
├── Services/
├── Models/
├── Views/
└── Program.cs
```

### Filters Included
- AuthenticationFilter
- AuthorizationFilter
- LoggingFilter
- ExceptionFilter

### Services Included
- AuthService
- LoggingService

---

# Testing URLs

## E-Commerce Application

### Home Page

```text
/Home/Index
```

### Products Page

```text
/Home/Products
```

### Error Testing

```text
/Home/ErrorTest
```

---

## Banking Application

### Home Page

```text
/Bank/Index
```

### Account Page

```text
/Bank/Account
```

### Admin Page

```text
/Bank/Admin
```

### Error Testing

```text
/Bank/ErrorTest
```

---

# Expected Output

## E-Commerce Application
- Successful request and response logging
- Protected products page access
- Global exception handling
- Friendly error page display

## Banking Application
- Authentication validation
- Authorization validation
- Activity logging
- Secure role-based access
- Global error handling

---


