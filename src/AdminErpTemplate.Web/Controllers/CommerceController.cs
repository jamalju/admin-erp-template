using AdminErpTemplate.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Web.Controllers;

public class CommerceController : Controller
{
    public CommerceController()
    {
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
}
