using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System;

namespace AdminErpTemplate.Web.Views.Dashboard
{
    public class OrdersModel : PageModel
    {
        public List<Order> Orders { get; set; }

        public void OnGet()
        {
            Orders = new List<Order>
            {
                new Order { Id = 1001, Customer = "Alice", Total = 1200.50m, Date = DateTime.Today.AddDays(-2) },
                new Order { Id = 1002, Customer = "Bob", Total = 75.00m, Date = DateTime.Today.AddDays(-1) },
                new Order { Id = 1003, Customer = "Charlie", Total = 15.99m, Date = DateTime.Today }
            };
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
