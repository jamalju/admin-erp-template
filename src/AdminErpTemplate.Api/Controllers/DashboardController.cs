using AdminErpTemplate.Core.DTOs;
using AdminErpTemplate.Core.Interfaces;
using AdminErpTemplate.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    [HttpGet]
    public ActionResult<ApiResponse<DashboardData>> GetDashboardData()
    {
        var data = _dashboardService.GetDashboardData();
        return Ok(new ApiResponse<DashboardData>
        {
            Success = true,
            Data = data
        });
    }

    [HttpGet("kpi")]
    public ActionResult<ApiResponse<List<DashboardWidget>>> GetKpiCards()
    {
        var data = _dashboardService.GetDashboardData();
        return Ok(new ApiResponse<List<DashboardWidget>>
        {
            Success = true,
            Data = data.KpiCards
        });
    }

    [HttpGet("activities")]
    public ActionResult<ApiResponse<List<RecentActivity>>> GetRecentActivities()
    {
        var data = _dashboardService.GetDashboardData();
        return Ok(new ApiResponse<List<RecentActivity>>
        {
            Success = true,
            Data = data.RecentActivities
        });
    }

    [HttpGet("top-products")]
    public ActionResult<ApiResponse<List<TopProduct>>> GetTopProducts()
    {
        var data = _dashboardService.GetDashboardData();
        return Ok(new ApiResponse<List<TopProduct>>
        {
            Success = true,
            Data = data.TopProducts
        });
    }

    [HttpGet("charts")]
    public ActionResult<ApiResponse<List<ChartData>>> GetCharts()
    {
        var data = _dashboardService.GetDashboardData();
        return Ok(new ApiResponse<List<ChartData>>
        {
            Success = true,
            Data = data.Charts
        });
    }
}
