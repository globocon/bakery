
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class OrderConfirmData
    {
        [Key]
        public int ReportId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductMRP { get; set; }
        public string? ImgFileExtn { get; set; }
        public float ProductOrderQuantity { get; set; }
        public DateTime? OrderDeliveryDateTime { get; set; }
        public int RawMaterialId { get; set; }
        public string RawMaterialName { get; set; }
        public float RawMaterialStockQuantity { get; set; }
        public float RawMaterialRequiredQuantity { get; set; }
        public decimal RawMaterialCP { get; set; }
        public string RawMaterialUnit { get; set; }
        public string? RawMaterialMapType { get; set; }
        public bool ShowInReport { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string ProductUom { get; set; }
        public int ProductSortOrder { get; set; } = 0;

    }
}
