namespace AdminErpTemplate.Core.Models;

public class FooterConfig
{
    public string CompanyName { get; set; } = "AdminERP";
    public string Copyright { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<FooterColumn> Columns { get; set; } = new();
    public List<SocialLink> SocialLinks { get; set; } = new();
}

public class FooterColumn
{
    public string Title { get; set; } = string.Empty;
    public List<FooterLink> Links { get; set; } = new();
}

public class FooterLink
{
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = "#";
    public string? Icon { get; set; }
}

public class SocialLink
{
    public string Platform { get; set; } = string.Empty;
    public string Url { get; set; } = "#";
    public string Icon { get; set; } = string.Empty;
}
