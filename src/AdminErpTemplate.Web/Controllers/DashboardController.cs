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

    public IActionResult Products()
    {
        var products = new List<Models.Product>
        {
            new Models.Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
            new Models.Product { Id = 2, Name = "T-Shirt", Price = 19.99m, Category = "Apparel" },
            new Models.Product { Id = 3, Name = "Coffee Mug", Price = 7.99m, Category = "Home" }
        };
        return View(products);
    }

    public IActionResult Orders()
    {
        var orders = new List<Models.Order>
        {
            new Models.Order { Id = 1001, Customer = "Alice", Total = 1200.50m, Date = DateTime.Today.AddDays(-2) },
            new Models.Order { Id = 1002, Customer = "Bob", Total = 75.00m, Date = DateTime.Today.AddDays(-1) },
            new Models.Order { Id = 1003, Customer = "Charlie", Total = 15.99m, Date = DateTime.Today }
        };
        return View(orders);
    }
    public IActionResult Customers()
    {
        var customers = new List<Models.Customer>
        {
            new Models.Customer { Id = 1, Name = "Alice Smith", Email = "alice@example.com", Phone = "123-456-7890" },
            new Models.Customer { Id = 2, Name = "Bob Johnson", Email = "bob@example.com", Phone = "234-567-8901" },
            new Models.Customer { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", Phone = "345-678-9012" }
        };
        return View(customers);
    }

    public IActionResult Inventory()
    {
        var inventory = new List<Models.InventoryItem>
        {
            new Models.InventoryItem { Id = 1, Name = "Laptop", Quantity = 10, Location = "Warehouse A" },
            new Models.InventoryItem { Id = 2, Name = "T-Shirt", Quantity = 50, Location = "Warehouse B" },
            new Models.InventoryItem { Id = 3, Name = "Coffee Mug", Quantity = 100, Location = "Warehouse C" }
        };
        return View(inventory);
    }
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
