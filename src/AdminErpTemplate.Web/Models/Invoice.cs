using System;

namespace AdminErpTemplate.Web.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
