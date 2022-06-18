namespace PostbankApp.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int SaleValue { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Status { get; set; }
        public Sale() { }
    }
}
