using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMS.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }
        public string Name { get; set; }
        public decimal MRP { get; set; }
        public string? ImgFileExtn { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        public Category Category { get; set; }
        public SubCategory? SubCategory { get; set; }
        public ICollection<ProductRawMaterial> ProductRawMaterials { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
