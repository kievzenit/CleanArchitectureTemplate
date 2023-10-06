---
# Project Name
Clean architecture template is the project that helps easely start with clean architecture in C#.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Folder Structure](#folder-structure)
- [Technologies Used](#technologies-used)
- [License](#license)

## Overview
This project helps you quickly create new clean architecture project with only essentials installed, so your dependecies won't be messed. Using MediatR derevative ICommand, IQuery for message processing in Application layer. Using minimal web api approach in Presentation layer, so you up to date with technologies. Architecture test written for you, so you will get tests fail if you break clean architecture segregation rules.

## Features
- **Modularity:** Organized into distinct layers - Presentation, Application, Domain, and Infrastructure.
- **Testability:** Built with unit testing and dependency injection in mind for easy testing.
- **Separation of Concerns:** Clearly defined boundaries between application layers.
- **Flexibility:** Easily extensible and customizable for different project requirements.

## Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download) installed
- Code editor you prefer (Rider, VSCode, Visual Studio)

## Getting Started

Install template:
```bash
# Clone the repository
git clone https://github.com/kievzenit/CleanArchitectureTemplate.git

# Install template
dotnet new install CleanArchitectureTemplate

# Use template to start new project
dotnet new cleanarchitecture-4tier -o NewProject

# Change director
cd NewProject

# Test the project
dotnet test

# Run the project
dotnet run
```

Or you can use this project directly:

```bash
# Clone the repository
git clone https://github.com/kievzenit/CleanArchitectureTemplate.git

# Change directory
cd CleanArchitectureTemplate

# Test the project
dotnet test

# Run the project
dotnet run
```

## Folder Structure

    src/CleanArchitectureTemplate.Api: Orchestration project, main api app.
    src/CleanArchitectureTemplate.Domain: Contains domain entities, business rules, and interfaces.
    src/CleanArchitectureTemplate.Application: Contains application logic and use cases.
    src/CleanArchitectureTemplate.Presentation: Contains the user interface layer (web API, MVC, etc.).
    src/CleanArchitectureTemplate.Infrastructure: Contains implementations for external services, databases, etc.
    tests/CleanArchitectureTemplate.ArchitectureTests: Contains architecture tests for the application.
    tests/CleanArchitectureTemplate.UnitTests.Application: Contains unit tests for the application.
    tests/CleanArchitectureTemplate.IntegrationTests: Contains integration tests for the application.

## Technologies Used

    C#
    ASP.NET Core
    Minimal web APIs
    MediatR
    xUnit
    NSubstitute
    Testcontainers
    Testcontainers.PosgtreSql
    Dependency Injection

## License

This project is licensed under the MIT - see the LICENSE.md file for details.
