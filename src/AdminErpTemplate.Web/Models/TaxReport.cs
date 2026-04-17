using System;

namespace AdminErpTemplate.Web.Models
{
    public class TaxReport
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public decimal Amount { get; set; }
    }
}
