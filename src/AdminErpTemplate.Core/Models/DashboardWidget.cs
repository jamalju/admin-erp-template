namespace AdminErpTemplate.Core.Models;

public class DashboardWidget
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Color { get; set; } = "primary";
    public string? Change { get; set; }
    public bool IsPositiveChange { get; set; }
    public string? ChartData { get; set; }
}

public class DashboardData
{
    public List<DashboardWidget> KpiCards { get; set; } = new();
    public List<ChartData> Charts { get; set; } = new();
    public List<RecentActivity> RecentActivities { get; set; } = new();
    public List<TopProduct> TopProducts { get; set; } = new();
}

public class ChartData
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = "line";
    public List<string> Labels { get; set; } = new();
    public List<DataSet> DataSets { get; set; } = new();
}

public class DataSet
{
    public string Label { get; set; } = string.Empty;
    public List<double> Data { get; set; } = new();
    public string? BackgroundColor { get; set; }
    public string? BorderColor { get; set; }
}

public class RecentActivity
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Color { get; set; } = "primary";
}

public class TopProduct
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Sold { get; set; }
    public decimal Revenue { get; set; }
    public string Status { get; set; } = string.Empty;
}
