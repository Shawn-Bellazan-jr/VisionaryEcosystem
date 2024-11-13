# VisionaryEcosystem

**VisionaryEcosystem** is a modular, scalable, and community-driven application ecosystem built on **.NET Aspire 9.0**. This project leverages a clean, layered architecture with a .NET Core API, Blazor WebAssembly for the front end, and comprehensive service modules to support professional growth, interactive knowledge sharing, and community engagement.

## Key Features
- **Clean Architecture**: Organized with separate layers for Core, Application, Infrastructure, and Presentation (API/Blazor).
- **Blazor WebAssembly Frontend**: A responsive, interactive UI built with Blazor for a seamless single-page application experience.
- **RESTful API**: A .NET Core API providing secure, efficient data handling and services.
- **Dependency Injection & Design Patterns**: Implements repository and service patterns, ensuring scalability and maintainability.
- **Community-Driven Modules**: Designed for professional growth, knowledge sharing, and feedback.

## Technologies & Libraries
- **.NET Core 6+ / .NET Aspire 9.0**: Provides a robust foundation for back-end and front-end development.
- **Entity Framework Core**: ORM for database access and management.
- **Swashbuckle/Swagger**: Interactive API documentation and testing.
- **AutoMapper**: Simplifies data transformations.
- **HttpClientFactory**: Manages HTTP client instances, optimizing API calls.
  
## Get Started
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/VisionaryEcosystem.git
   ```
2. **Configure & Run**:
   - Configure `appsettings.json` for database and API settings.
   - Run `dotnet run` in the `VisionaryEcosystem.API` project.
3. **Access Swagger Documentation**:
   - Navigate to `https://localhost:5001/swagger` to explore and test API endpoints.

## Project Structure
```plaintext
VisionaryEcosystem
??? src
?   ??? VisionaryEcosystem.API                 # Backend API
?   ??? VisionaryEcosystem.BlazorApp           # Blazor WebAssembly client
?   ??? VisionaryEcosystem.Core                # Core project with shared models and interfaces
?   ??? VisionaryEcosystem.Application         # Business logic and services
?   ??? VisionaryEcosystem.Infrastructure      # Data access and third-party integrations
?   ??? VisionaryEcosystem.ServiceDefaults     # Common services and settings
?   ??? VisionaryEcosystem.AppHost             # Application host/orchestration layer
??? tests
    ??? VisionaryEcosystem.Tests               # Unit tests
    ??? VisionaryEcosystem.IntegrationTests    # Integration tests
```

## Contributions
Contributions are welcome! Please see the [CONTRIBUTING.md](CONTRIBUTING.md) file for more information on how to get involved.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.