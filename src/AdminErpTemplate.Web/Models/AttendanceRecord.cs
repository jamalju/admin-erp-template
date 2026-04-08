using System;

namespace AdminErpTemplate.Web.Models
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
