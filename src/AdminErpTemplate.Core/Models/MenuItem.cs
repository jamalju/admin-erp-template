namespace AdminErpTemplate.Core.Models;

public class MenuItem
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Url { get; set; } = "#";
    public string? Badge { get; set; }
    public string? BadgeColor { get; set; }
    public bool IsActive { get; set; }
    public bool IsExpanded { get; set; }
    public int Order { get; set; }
    public string? Section { get; set; }
    public List<MenuItem> Children { get; set; } = new();
}
