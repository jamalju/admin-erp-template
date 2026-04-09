using System;

namespace AdminErpTemplate.Web.Models
{
    public class TimelineEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
