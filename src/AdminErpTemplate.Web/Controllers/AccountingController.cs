using AdminErpTemplate.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Web.Controllers;

public class AccountingController : Controller
{
    private readonly IMenuService _menuService;
    private readonly IDashboardService _dashboardService;

    public AccountingController(IMenuService menuService, IDashboardService dashboardService)
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
    public IActionResult Employees()
    {
        var employees = new List<Models.Employee>
        {
            new Models.Employee { Id = 1, Name = "Alice Smith", Position = "Manager", Department = "Sales" },
            new Models.Employee { Id = 2, Name = "Bob Johnson", Position = "Developer", Department = "IT" },
            new Models.Employee { Id = 3, Name = "Charlie Brown", Position = "Accountant", Department = "Finance" }
        };
        return View(employees);
    }

    public IActionResult Departments()
    {
        var departments = new List<Models.Department>
        {
            new Models.Department { Id = 1, Name = "Sales", Manager = "Alice Smith" },
            new Models.Department { Id = 2, Name = "IT", Manager = "Bob Johnson" },
            new Models.Department { Id = 3, Name = "Finance", Manager = "Charlie Brown" }
        };
        return View(departments);
    }

    public IActionResult Attendance()
    {
        var attendance = new List<Models.AttendanceRecord>
        {
            new Models.AttendanceRecord { Id = 1, Employee = "Alice Smith", Date = DateTime.Today, Status = "Present" },
            new Models.AttendanceRecord { Id = 2, Employee = "Bob Johnson", Date = DateTime.Today, Status = "Absent" },
            new Models.AttendanceRecord { Id = 3, Employee = "Charlie Brown", Date = DateTime.Today, Status = "Present" }
        };
        return View(attendance);
    }

    public IActionResult Payroll()
    {
        var payroll = new List<Models.PayrollRecord>
        {
            new Models.PayrollRecord { Id = 1, Employee = "Alice Smith", Amount = 2500.00m, Date = DateTime.Today.AddDays(-5) },
            new Models.PayrollRecord { Id = 2, Employee = "Bob Johnson", Amount = 1800.00m, Date = DateTime.Today.AddDays(-5) },
            new Models.PayrollRecord { Id = 3, Employee = "Charlie Brown", Amount = 2000.00m, Date = DateTime.Today.AddDays(-5) }
        };
        return View(payroll);
    }
    public IActionResult Invoices()
    {
        var invoices = new List<Models.Invoice>
        {
            new Models.Invoice { Id = 1, Customer = "Alice Smith", Amount = 500.00m, Date = DateTime.Today.AddDays(-10) },
            new Models.Invoice { Id = 2, Customer = "Bob Johnson", Amount = 1200.00m, Date = DateTime.Today.AddDays(-7) },
            new Models.Invoice { Id = 3, Customer = "Charlie Brown", Amount = 300.00m, Date = DateTime.Today.AddDays(-3) }
        };
        return View(invoices);
    }

    public IActionResult Expenses()
    {
        var expenses = new List<Models.Expense>
        {
            new Models.Expense { Id = 1, Description = "Office Supplies", Amount = 150.00m, Date = DateTime.Today.AddDays(-12) },
            new Models.Expense { Id = 2, Description = "Travel", Amount = 800.00m, Date = DateTime.Today.AddDays(-8) },
            new Models.Expense { Id = 3, Description = "Utilities", Amount = 200.00m, Date = DateTime.Today.AddDays(-2) }
        };
        return View(expenses);
    }

    public IActionResult Reports()
    {
        var reports = new List<Models.Report>
        {
            new Models.Report { Id = 1, Title = "Sales Report", Type = "Sales", Date = DateTime.Today.AddDays(-30) },
            new Models.Report { Id = 2, Title = "Inventory Report", Type = "Inventory", Date = DateTime.Today.AddDays(-20) },
            new Models.Report { Id = 3, Title = "Expense Report", Type = "Finance", Date = DateTime.Today.AddDays(-10) }
        };
        return View(reports);
    }

    public IActionResult TaxSettings()
    {
        var taxSettings = new List<Models.TaxSetting>
        {
            new Models.TaxSetting { Id = 1, Name = "VAT", Rate = 0.15m },
            new Models.TaxSetting { Id = 2, Name = "GST", Rate = 0.10m },
            new Models.TaxSetting { Id = 3, Name = "Service Tax", Rate = 0.05m }
        };
        return View(taxSettings);
    }

    public IActionResult TaxReports()
    {
        var taxReports = new List<Models.TaxReport>
        {
            new Models.TaxReport { Id = 1, Period = "Q1 2024", Amount = 1500.00m },
            new Models.TaxReport { Id = 2, Period = "Q2 2024", Amount = 1800.00m },
            new Models.TaxReport { Id = 3, Period = "Q3 2024", Amount = 2100.00m }
        };
        return View(taxReports);
    }
    public IActionResult Leads()
    {
        var leads = new List<Models.Lead>
        {
            new Models.Lead { Id = 1, Name = "Acme Corp", Source = "Web", Status = "New" },
            new Models.Lead { Id = 2, Name = "Beta LLC", Source = "Referral", Status = "Contacted" },
            new Models.Lead { Id = 3, Name = "Gamma Inc", Source = "Email", Status = "Qualified" }
        };
        return View(leads);
    }

    public IActionResult Deals()
    {
        var deals = new List<Models.Deal>
        {
            new Models.Deal { Id = 1, Title = "ERP Implementation", Customer = "Acme Corp", Value = 10000m, Stage = "Negotiation" },
            new Models.Deal { Id = 2, Title = "Support Contract", Customer = "Beta LLC", Value = 2500m, Stage = "Proposal" },
            new Models.Deal { Id = 3, Title = "Upgrade Project", Customer = "Gamma Inc", Value = 5000m, Stage = "Closed Won" }
        };
        return View(deals);
    }

    public IActionResult Contacts()
    {
        var contacts = new List<Models.Contact>
        {
            new Models.Contact { Id = 1, Name = "Alice Smith", Email = "alice@example.com", Phone = "123-456-7890" },
            new Models.Contact { Id = 2, Name = "Bob Johnson", Email = "bob@example.com", Phone = "234-567-8901" },
            new Models.Contact { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", Phone = "345-678-9012" }
        };
        return View(contacts);
    }

    public IActionResult Projects()
    {
        var projects = new List<Models.Project>
        {
            new Models.Project { Id = 1, Name = "ERP Launch", Manager = "Alice Smith", Status = "Active" },
            new Models.Project { Id = 2, Name = "Website Redesign", Manager = "Bob Johnson", Status = "Planning" },
            new Models.Project { Id = 3, Name = "Mobile App", Manager = "Charlie Brown", Status = "Completed" }
        };
        return View(projects);
    }

    public IActionResult Tasks()
    {
        var tasks = new List<Models.TaskItem>
        {
            new Models.TaskItem { Id = 1, Title = "Setup Database", AssignedTo = "Alice Smith", Status = "Done" },
            new Models.TaskItem { Id = 2, Title = "Design UI", AssignedTo = "Bob Johnson", Status = "In Progress" },
            new Models.TaskItem { Id = 3, Title = "Write Documentation", AssignedTo = "Charlie Brown", Status = "To Do" }
        };
        return View(tasks);
    }

    public IActionResult Timeline()
    {
        var timeline = new List<Models.TimelineEvent>
        {
            new Models.TimelineEvent { Id = 1, Title = "Project Kickoff", Date = DateTime.Today.AddDays(-30), Description = "Initial meeting with stakeholders." },
            new Models.TimelineEvent { Id = 2, Title = "Phase 1 Complete", Date = DateTime.Today.AddDays(-15), Description = "Development phase 1 finished." },
            new Models.TimelineEvent { Id = 3, Title = "Go Live", Date = DateTime.Today, Description = "System launched to production." }
        };
        return View(timeline);
    }
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
