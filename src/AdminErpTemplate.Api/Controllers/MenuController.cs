using AdminErpTemplate.Core.DTOs;
using AdminErpTemplate.Core.Interfaces;
using AdminErpTemplate.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpGet("sidebar")]
    public ActionResult<ApiResponse<List<MenuItem>>> GetSidebarMenu()
    {
        var menu = _menuService.GetSidebarMenu();
        return Ok(new ApiResponse<List<MenuItem>>
        {
            Success = true,
            Data = menu
        });
    }

    [HttpGet("horizontal")]
    public ActionResult<ApiResponse<List<MenuItem>>> GetHorizontalMenu()
    {
        var menu = _menuService.GetHorizontalMenu();
        return Ok(new ApiResponse<List<MenuItem>>
        {
            Success = true,
            Data = menu
        });
    }

    [HttpGet("footer")]
    public ActionResult<ApiResponse<FooterConfig>> GetFooterConfig()
    {
        var footer = _menuService.GetFooterConfig();
        return Ok(new ApiResponse<FooterConfig>
        {
            Success = true,
            Data = footer
        });
    }
}
