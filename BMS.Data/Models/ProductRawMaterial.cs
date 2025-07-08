
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class ProductRawMaterial
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RawMaterialId { get; set; }
        public float QuantityRequired { get; set; }

        public Product? Product { get; set; }
        public RawMaterial? RawMaterial { get; set; }
        
        public override string ToString()
        {
            return $"ProductRawMaterial Id: {Id}, ProductId: {ProductId}, RawMaterialId: {RawMaterialId}, QuantityRequired: {QuantityRequired}";
        }
    }
}
