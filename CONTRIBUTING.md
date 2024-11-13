# Contributing to VisionaryEcosystem

Welcome, and thank you for your interest in contributing to **VisionaryEcosystem**! We’re excited to collaborate with developers to build a scalable, community-driven application ecosystem on .NET Aspire. This document provides guidelines for contributing to the project, including setting up the environment, coding standards, and submitting changes.

---

## Table of Contents

1. [Code of Conduct](#code-of-conduct)
2. [How to Contribute](#how-to-contribute)
3. [Project Setup](#project-setup)
4. [Development Standards](#development-standards)
5. [Pull Request Process](#pull-request-process)
6. [Reporting Issues](#reporting-issues)
7. [Additional Resources](#additional-resources)

---

## Code of Conduct

Please read and follow our [Code of Conduct](CODE_OF_CONDUCT.md). We aim to create a respectful and welcoming environment for everyone.

## How to Contribute

There are many ways you can contribute to VisionaryEcosystem, including:

- **Reporting Bugs**: Use the [issue tracker](https://github.com/Shawn-Bellazan-jr/VisionaryEcosystem/issues) to report bugs.
- **Suggesting Features**: Share ideas for new features or enhancements.
- **Improving Documentation**: Help us improve this `README.md`, add examples, or create tutorials.
- **Submitting Code**: You can add new features, fix bugs, or refactor existing code to improve the project.

## Project Setup

To get started with the project, follow these steps:

### 1. Clone the Repository
Clone the repository to your local machine:
```bash
git clone https://github.com/Shawn-Bellazan-jr/VisionaryEcosystem.git
cd VisionaryEcosystem
```

### 2. Set Up the Environment
Make sure you have the following tools installed:
- **.NET SDK 6.0+** or **.NET Aspire 9.0**
- **Visual Studio 2022** (or Visual Studio Code with .NET support)
- **SQL Server** (or another configured database provider, if applicable)

### 3. Configure Environment Variables
Create an `appsettings.Development.json` file in the `VisionaryEcosystem.API` project with your local configurations (e.g., database connection strings).

Example:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YourDatabaseConnectionString"
  }
}
```

### 4. Run the Application
Navigate to the API project and start the application:
```bash
dotnet run --project src/VisionaryEcosystem.API
```

The API should be accessible at `https://localhost:5001`. You can access the Swagger documentation at `/swagger` to explore API endpoints.

## Development Standards

### Code Style

- **Follow C# Naming Conventions**: Use PascalCase for public members and camelCase for local variables.
- **Use Dependency Injection (DI)**: All services should be injected rather than instantiated directly.
- **Comment and Document**: Use XML comments for public methods and properties.
- **Modularization**: Ensure each service or module adheres to single responsibility principles.

### Git Commit Messages
- Use clear and descriptive commit messages.
- Prefix messages with a relevant label: `[Feature]`, `[Fix]`, `[Refactor]`, `[Docs]`.
  - Example: `[Feature] Add JWT authentication to API`

### Testing
- **Unit Tests**: Write tests for each new service, business logic, or model.
- **Integration Tests**: For new API endpoints, add tests to validate end-to-end functionality.
- Place tests in the `VisionaryEcosystem.Tests` and `VisionaryEcosystem.IntegrationTests` folders.

## Pull Request Process

1. **Fork the Repository**: Start by creating a fork of the main repository.
2. **Create a Branch**: Name your branch based on the feature or fix (e.g., `feature/add-authentication`).
3. **Make Your Changes**: Commit your changes to the branch.
4. **Push and Submit a PR**:
   - Push the branch to your forked repository.
   - Go to the original repository and submit a Pull Request (PR).
5. **Describe Your PR**:
   - Clearly describe the purpose of the PR, referencing any related issues.
   - Include screenshots or examples if applicable.
6. **Respond to Feedback**: A maintainer will review your PR. Please make changes if requested.

## Reporting Issues

If you find any bugs or want to suggest improvements, please open an issue:

1. Go to the [Issues page](https://github.com/Shawn-Bellazan-jr/VisionaryEcosystem/issues).
2. Click on **New Issue**.
3. Provide a descriptive title and detailed information about the issue.
4. Add appropriate labels (e.g., `bug`, `enhancement`) and assign it to a project milestone if applicable.

## Additional Resources

- **Documentation**: See the `README.md` file for more details on project structure and features.
- **License**: This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

Thank you for your interest in improving VisionaryEcosystem! Your contributions help make this project better for everyone.
