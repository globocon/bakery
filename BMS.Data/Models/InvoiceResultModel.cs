namespace BMS.Data.Models
{
    public class InvoiceResultModel
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public List<InvoiceItemResultModel> Items { get; set; } = new();
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public Customer Customer { get; set; }
    }

    public class InvoiceItemResultModel
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}