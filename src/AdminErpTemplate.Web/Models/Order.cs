using System;

namespace AdminErpTemplate.Web.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
