using AdminErpTemplate.Core.Models;

namespace AdminErpTemplate.Core.Interfaces;

public interface IMenuService
{
    List<MenuItem> GetSidebarMenu();
    List<MenuItem> GetHorizontalMenu();
    FooterConfig GetFooterConfig();
}
