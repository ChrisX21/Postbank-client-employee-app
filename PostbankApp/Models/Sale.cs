namespace PostbankApp.Models
{
    public enum SaleStatus
    {
        Active = 0,
        Expired,
        Rejected,
        Waiting
    }
    public class Sale
    {
        public string Id { get; set; }
        public string SalerId { get; set; }
        public int SaleValue { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Status { get; set; }
        public Sale() { }
    }
}
