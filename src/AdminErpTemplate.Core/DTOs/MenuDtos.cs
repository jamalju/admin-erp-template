using AdminErpTemplate.Core.Enums;

namespace AdminErpTemplate.Core.DTOs;

public class MenuItemDto
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Url { get; set; } = "#";
    public string? Badge { get; set; }
    public string? BadgeColor { get; set; }
    public int Order { get; set; }
    public string? Section { get; set; }
    public List<MenuItemDto> Children { get; set; } = new();
}

public class ThemeSettingsDto
{
    public string Mode { get; set; } = "light";
    public string ColorScheme { get; set; } = "default";
    public string MenuLayout { get; set; } = "sidebar";
    public bool SidebarCollapsed { get; set; }
    public bool FixedHeader { get; set; } = true;
    public bool FixedSidebar { get; set; } = true;
}

public class DashboardDto
{
    public List<KpiCardDto> KpiCards { get; set; } = new();
    public object? RevenueChart { get; set; }
    public object? OrdersChart { get; set; }
    public List<ActivityDto> RecentActivities { get; set; } = new();
    public List<TopProductDto> TopProducts { get; set; } = new();
}

public class KpiCardDto
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Color { get; set; } = "primary";
    public string? Change { get; set; }
    public bool IsPositiveChange { get; set; }
}

public class ActivityDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Color { get; set; } = "primary";
}

public class TopProductDto
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public int Sold { get; set; }
    public string Revenue { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
