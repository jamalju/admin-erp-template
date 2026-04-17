using AdminErpTemplate.Core.DTOs;
using AdminErpTemplate.Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThemeController : ControllerBase
{
    [HttpGet("schemes")]
    public ActionResult<ApiResponse<List<object>>> GetColorSchemes()
    {
        var schemes = new List<object>
        {
            new { Id = "default", Name = "Default", Primary = "#6366f1", Secondary = "#64748b" },
            new { Id = "blue", Name = "Ocean Blue", Primary = "#3b82f6", Secondary = "#1e40af" },
            new { Id = "green", Name = "Forest Green", Primary = "#22c55e", Secondary = "#15803d" },
            new { Id = "purple", Name = "Royal Purple", Primary = "#a855f7", Secondary = "#7e22ce" },
            new { Id = "red", Name = "Ruby Red", Primary = "#ef4444", Secondary = "#b91c1c" },
            new { Id = "orange", Name = "Sunset Orange", Primary = "#f97316", Secondary = "#c2410c" },
            new { Id = "teal", Name = "Teal", Primary = "#14b8a6", Secondary = "#0f766e" }
        };

        return Ok(new ApiResponse<List<object>>
        {
            Success = true,
            Data = schemes
        });
    }

    [HttpGet("modes")]
    public ActionResult<ApiResponse<List<string>>> GetThemeModes()
    {
        var modes = Enum.GetNames<ThemeMode>().ToList();
        return Ok(new ApiResponse<List<string>>
        {
            Success = true,
            Data = modes
        });
    }

    [HttpGet("layouts")]
    public ActionResult<ApiResponse<List<string>>> GetMenuLayouts()
    {
        var layouts = Enum.GetNames<MenuLayout>().ToList();
        return Ok(new ApiResponse<List<string>>
        {
            Success = true,
            Data = layouts
        });
    }
}
