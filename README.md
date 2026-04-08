# AdminERP - Unified Advanced ERP Admin Template

A full-featured ASP.NET Core 8.0 ERP admin template designed to be API-driven and compatible with any frontend framework (React, Angular, Vue, MAUI, etc.).

## Features

- **Bootstrap 5.3 + Custom CSS Variables** - Fully themeable with CSS custom properties
- **Dark / Light Mode** - Toggle between themes with localStorage persistence
- **7 Color Schemes** - Default, Ocean Blue, Forest Green, Royal Purple, Ruby Red, Sunset Orange, Teal
- **Multi-level Dynamic Sidebar** - JSON-driven, collapsible, with section headers and badges
- **Horizontal Mega Menu** - Switch between sidebar and mega menu layouts on-the-fly
- **Mega Footer** - Multi-column footer with social links, navigation columns, and branding
- **Dashboard** - KPI cards, Chart.js revenue/category charts, activity timeline, top products table
- **Breadcrumb** - Auto-generated breadcrumb navigation on every page
- **Fully Responsive** - Mobile-first design with tablet/desktop breakpoints
- **API-Based Architecture** - REST API with Swagger/OpenAPI, CORS enabled for any client
- **JWT-Ready Auth** - Authentication endpoints ready for token-based auth
- **Clean Architecture** - Core, Infrastructure, API, and Web projects separated

## Project Structure

```
AdminErpTemplate.sln
├── src/
│   ├── AdminErpTemplate.Core/          # Models, DTOs, Interfaces, Enums
│   ├── AdminErpTemplate.Infrastructure/ # Service implementations
│   ├── AdminErpTemplate.Api/           # REST API (Swagger at /swagger)
│   └── AdminErpTemplate.Web/           # MVC frontend with Razor views
```

## Quick Start

```bash
# Prerequisites: .NET 8.0 SDK

# Build
dotnet build

# Run the Web UI (default: http://localhost:5180)
dotnet run --project src/AdminErpTemplate.Web

# Run the API (default: http://localhost:5047)
dotnet run --project src/AdminErpTemplate.Api
```

## API Endpoints

| Endpoint | Method | Description |
|---|---|---|
| `/api/auth/login` | POST | Authenticate user (demo: admin/admin123) |
| `/api/auth/user/{id}` | GET | Get user info |
| `/api/menu/sidebar` | GET | Get sidebar menu structure |
| `/api/menu/horizontal` | GET | Get horizontal mega menu structure |
| `/api/menu/footer` | GET | Get footer configuration |
| `/api/dashboard` | GET | Get full dashboard data |
| `/api/dashboard/kpi` | GET | Get KPI cards |
| `/api/dashboard/activities` | GET | Get recent activities |
| `/api/dashboard/top-products` | GET | Get top products |
| `/api/dashboard/charts` | GET | Get chart data |
| `/api/theme/schemes` | GET | Get available color schemes |
| `/api/theme/modes` | GET | Get theme modes |
| `/api/theme/layouts` | GET | Get menu layout options |

## Demo Accounts

| Username | Password | Role |
|---|---|---|
| admin | admin123 | Administrator |
| manager | manager123 | Manager |
| user | user123 | User |

## License

MIT
