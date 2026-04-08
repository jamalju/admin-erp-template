using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AdminErpTemplate.Web.Views.Dashboard
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
                new Product { Id = 2, Name = "T-Shirt", Price = 19.99m, Category = "Apparel" },
                new Product { Id = 3, Name = "Coffee Mug", Price = 7.99m, Category = "Home" }
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
