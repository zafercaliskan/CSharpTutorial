# C# Tutorial & Reference Projects

This repository contains a comprehensive collection of C# tutorials and reference implementations, designed to demonstrate core C# concepts, Object-Oriented Programming (OOP) principles, and modern .NET development practices.

The solution has been upgraded to **.NET 10.0** and refactored to follow professional coding standards and English naming conventions.

## Project Structure & Content

The solution consists of multiple isolated console and Windows Forms applications, each focusing on specific topics:

### Core Concepts
*   **`TypesAndVariables`**: Introduction to value types, reference types, and variable declarations.
*   **`Conditionals`**: Usage of `if-else`, `switch-case` blocks.
*   **`Loops`**: Implementation of `for`, `foreach`, `while`, and `do-while` loops.
*   **`Strings`**: String manipulation and common string methods.
*   **`Arrays`**: Single and multi-dimensional arrays.
*   **`Maths`**: Basic arithmetic operations and method definitions (`FourOperations`).

### Object-Oriented Programming (OOP)
*   **`Classes`**: Fundamentals of Classes, Properties, and Encapsulation.
*   **`Methods`**, **`MethodsTwo`**, **`MethodOverloading`**: Deep dive into methods, `ref`/`out` keywords, `params`, and overloading.
*   **`Constructors`**: Constructor injection and object initialization.
*   **`Inheritance`**: Base classes, derived classes, and code reusability.
*   **`Interfaces`**, **`InterfacesTwo`**, **`InterfacesDemo`**: Interface-driven design, polymorphism, and dependency management.
*   **`AbstractClasses`**: Abstract methods and classes for defining templates.
*   **`VirtualMethods`**: Overriding virtual methods for polymorphic behavior.
*   **`AccessModifiers`**: `public`, `private`, `protected`, and `internal` modifiers.
*   **`RecapDemo`**: Review of Logger implementation strategies (Database, File, SMS) using Interfaces.

### Advanced Topics
*   **`Generics`**, **`GenericsIntro`**, **`MyDictionary`**: Creating custom generic collections and repository patterns (`IRepository<T>`).
*   **`Delegates`**: Function pointers, `Action`, `Func`.
*   **`Events`**: Event-driven programming.
*   **`Exceptions`**: Exception handling (`try-catch`) and creating custom exceptions.
*   **`Attributes`**: Custom attributes and reflection usage.
*   **`Reflection`**: Inspecting runtime type information.
*   **`Collections`**: `List`, `Dictionary`, and legacy variable types.

### Data Access & Real-World Simulations
*   **`OOP2`**: Corporate vs. Individual customer modeling using Inheritance/Polymorphism.
*   **`OOP3`**: Credit Application System simulation (`ICreditManager`, `ILoggerService`) demonstrating Dependency Injection and loosely coupled design.
*   **`GameProject`**: Simulation of a game sales platform with Gamer validation (e-Government), Promotions (`Campaign`), and Sales logic.
*   **`AdoNetDemo`**: CRUD operations using pure ADO.NET and `Microsoft.Data.SqlClient`.
*   **`EntityFrameworkDemo`**: CRUD operations using Entity Framework (ORM).

## Technologies

*   **Runtime**: .NET 10.0
*   **Language**: C# 12 / 13
*   **Project Types**: Console App, Windows Forms App
*   **Data Access**: ADO.NET, Entity Framework (Legacy & Core concepts)

## Getting Started

1.  **Prerequisites**: Ensure you have the .NET 10 SDK installed.
2.  **Clone**: Clone this repository.
3.  **Build**: Run `dotnet build` in the root directory.
4.  **Run**: Navigate to any project folder (e.g., `cd OOP3`) and run `dotnet run` (for Console apps).

## Clean Code Principles
This repository emphasizes:
*   **SOLID Principles** (Single Responsibility, Open/Closed, Dependency Inversion etc.)
*   **DRY** (Don't Repeat Yourself)
*   **Clean Naming** (English PascalCase/camelCase)
