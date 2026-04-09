namespace AdminErpTemplate.Web.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public decimal Value { get; set; }
        public string Stage { get; set; }
    }
}
