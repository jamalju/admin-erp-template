using AdminErpTemplate.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Web.Controllers;

public class DashboardController : Controller
{
    private readonly IMenuService _menuService;
    private readonly IDashboardService _dashboardService;

    public DashboardController(IMenuService menuService, IDashboardService dashboardService)
    {
        _menuService = menuService;
        _dashboardService = dashboardService;
    }

    public IActionResult Index()
    {
        var dashboardData = _dashboardService.GetDashboardData();
        return View(dashboardData);
    }

    public IActionResult Products() => View();
    public IActionResult Orders() => View();
    public IActionResult Customers() => View();
    public IActionResult Inventory() => View();
    public IActionResult Employees() => View();
    public IActionResult Departments() => View();
    public IActionResult Attendance() => View();
    public IActionResult Payroll() => View();
    public IActionResult Invoices() => View();
    public IActionResult Expenses() => View();
    public IActionResult Reports() => View();
    public IActionResult TaxSettings() => View();
    public IActionResult TaxReports() => View();
    public IActionResult Leads() => View();
    public IActionResult Deals() => View();
    public IActionResult Contacts() => View();
    public IActionResult Projects() => View();
    public IActionResult Tasks() => View();
    public IActionResult Timeline() => View();
    public IActionResult Buttons() => View();
    public IActionResult Cards() => View();
    public IActionResult Modals() => View();
    public IActionResult Tables() => View();
    public IActionResult Forms() => View();
    public IActionResult Charts() => View();
    public IActionResult Profile() => View();
    public IActionResult Settings() => View();
    public IActionResult Users() => View();
    public IActionResult NotificationSettings() => View();
    public IActionResult Error404() => View();
    public IActionResult Error500() => View();
}
