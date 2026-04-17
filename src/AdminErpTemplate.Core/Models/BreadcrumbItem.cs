namespace AdminErpTemplate.Core.Models;

public class BreadcrumbItem
{
    public string Title { get; set; } = string.Empty;
    public string? Url { get; set; }
    public string? Icon { get; set; }
    public bool IsActive { get; set; }
}
