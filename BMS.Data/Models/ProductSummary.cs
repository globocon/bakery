
namespace BMS.Data.Models
{
    public class ProductSummary
    {
        public int Index { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float TotalRequired { get; set; } // You can modify this now
        public int ProductSortOrder { get; set; }
    }
}
