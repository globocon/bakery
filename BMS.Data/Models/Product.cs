using iText.Layout.Borders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal MRP { get; set; }

        public Category Category { get; set; }
        public ICollection<ProductRawMaterial> ProductRawMaterials { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
