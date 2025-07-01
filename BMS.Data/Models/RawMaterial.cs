
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class RawMaterial
    {
        [Key]
        public int RawMaterialId { get; set; }
        public string Name { get; set; }
        public float StockQuantity { get; set; }
        public decimal CP { get; set; }
        public string Unit { get; set; }

        public ICollection<ProductRawMaterial> ProductRawMaterials { get; set; }
    }
}
