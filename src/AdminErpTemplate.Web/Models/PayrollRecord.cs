using System;

namespace AdminErpTemplate.Web.Models
{
    public class PayrollRecord
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
