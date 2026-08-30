# GridironIQ

A comprehensive fantasy football analytics API built with ASP.NET Core and PostgreSQL. GridironIQ provides player statistics, projections, rankings, and advanced analytics to power fantasy football applications.

## Project Overview

GridironIQ is a backend API service that aggregates NFL player data and provides fantasy football insights through a RESTful interface. This project serves as both a practical learning platform for modern C#/.NET development and a functional analytics engine for fantasy football decision-making.

### Key Features (Planned)

- **Player Data Management**: Comprehensive NFL player information, statistics, and game logs
- **Fantasy Projections**: Statistical models for weekly player performance predictions
- **Rankings Engine**: Position-based player rankings with customizable scoring formats
- **Waiver Wire Analysis**: Data-driven recommendations for free agent pickups
- **Trade Analyzer**: Fairness evaluation and impact assessment for proposed trades
- **Matchup Analysis**: Weekly opponent-based performance predictions
- **Machine Learning Integration**: Advanced predictive models using historical data

## Technology Stack

### Backend
- **ASP.NET Core 10** - Web API framework
- **Entity Framework Core** - ORM and database access
- **PostgreSQL** - Primary database
- **Swagger/OpenAPI** - API documentation and testing
- **Hangfire** - Background job scheduling and processing
- **Serilog** - Structured logging

### Future Additions
- **Redis** - Caching layer for performance optimization
- **Python Microservice** - ML model serving (FastAPI/Flask)
- **Docker** - Containerization and deployment
- **React** - Frontend web application

## Architecture

The project follows Clean Architecture principles with clear separation of concerns:

```
src/
├── GridironIQ.Api/              # Web API layer (controllers, middleware)
├── GridironIQ.Core/             # Domain models and interfaces
├── GridironIQ.Services/         # Business logic and analytics
└── GridironIQ.Infrastructure/   # Data access and external services
```

### Data Flow

```
External NFL Data Sources
         ↓
    Background Jobs
         ↓
    PostgreSQL Database
         ↓
    Business Logic Layer
         ↓
    REST API Endpoints
         ↓
    Client Applications
```

## API Endpoints (Planned)

### Players
- `GET /api/players` - List all players with filtering
- `GET /api/players/{id}` - Get player details
- `GET /api/players/{id}/stats` - Player season statistics
- `GET /api/players/{id}/projections` - Weekly projections
- `GET /api/players/{id}/game-log` - Historical game performance

### Rankings
- `GET /api/rankings` - Position-based player rankings
- `GET /api/rankings/weekly/{week}` - Week-specific rankings

### Analytics
- `GET /api/analytics/waivers` - Waiver wire recommendations
- `POST /api/analytics/trades` - Trade evaluation
- `GET /api/analytics/matchups/{week}` - Weekly matchup analysis

## Development Roadmap

### Phase 1: Foundation
- Initialize ASP.NET Core Web API project
- Set up basic project structure
- Create hardcoded player endpoints
- Implement Swagger documentation

### Phase 2: Database Integration
- Configure Entity Framework Core with PostgreSQL
- Design and implement core entities (Player, Team, GameLog)
- Add repository pattern
- Implement database migrations

### Phase 3: Data Pipeline
- Integrate external NFL data source
- Build background job for data synchronization
- Implement data transformation and validation
- Add error handling and retry logic

### Phase 4: Analytics Engine
- Develop projection algorithm
- Build rankings calculation service
- Create player performance analytics
- Implement caching strategy

### Phase 5: Advanced Features
- Waiver wire recommendation system
- Trade analyzer with fairness scoring
- Matchup difficulty analysis
- ML model integration

### Phase 6: Frontend
- React-based web application
- User authentication and league management
- Interactive dashboards and visualizations

## Getting Started

### Prerequisites
- .NET 10 SDK
- PostgreSQL 14+
- Visual Studio 2022 or VS Code with C# extension

### Installation

```bash
# Clone the repository
git clone https://github.com/yourusername/GridironIQ.git
cd GridironIQ

# Restore dependencies
dotnet restore

# Run database migrations
dotnet ef database update --project src/GridironIQ.Infrastructure

# Run the application
dotnet run --project src/GridironIQ.Api
```

## Project Goals

This project is designed as a learning platform to develop expertise in:

- Modern C# and .NET ecosystem
- RESTful API design and best practices
- Database design and Entity Framework Core
- Background job processing
- Async/await patterns and performance optimization
- Integration with external APIs
- Testing strategies (unit, integration, end-to-end)

## Why Fantasy Football?

Building a fantasy football API provides several advantages over generic CRUD applications:

1. **Real-world data complexity**: Handling external data sources, transformations, and scheduled updates
2. **Interesting domain logic**: Statistical calculations, projections, and recommendation algorithms
3. **Practical use case**: Solves actual problems for fantasy football players
4. **Scalability challenges**: Large datasets, complex queries, and performance optimization
5. **Cross-domain integration**: Combines traditional backend work with potential ML/AI features

## Contributing

This is primarily a personal learning project, but suggestions and feedback are welcome. Please open an issue to discuss proposed changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- NFL data sources and APIs that make this project possible
- The ASP.NET Core community for excellent documentation and resources
- Fantasy football community for inspiration and domain knowledge

