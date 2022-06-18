namespace PostbankApp.Models
{
    public class Sales
    {
        public string SalerId { get; set; }
        public string SaleID { get; set; }
        public int SaleValue { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Status { get; set; }
        public Sales() { }
    }
}
