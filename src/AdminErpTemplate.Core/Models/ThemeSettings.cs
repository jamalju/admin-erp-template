using AdminErpTemplate.Core.Enums;

namespace AdminErpTemplate.Core.Models;

public class ThemeSettings
{
    public ThemeMode Mode { get; set; } = ThemeMode.Light;
    public ColorScheme ColorScheme { get; set; } = ColorScheme.Default;
    public MenuLayout MenuLayout { get; set; } = MenuLayout.Sidebar;
    public bool SidebarCollapsed { get; set; }
    public bool FixedHeader { get; set; } = true;
    public bool FixedSidebar { get; set; } = true;
    public string LogoText { get; set; } = "AdminERP";
    public string LogoIcon { get; set; } = "bi-grid-1x2-fill";
}
