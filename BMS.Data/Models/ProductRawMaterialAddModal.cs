
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class ProductRawMaterialAddModal
    {      
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RawMaterialId { get; set; }
        public float QuantityRequired { get; set; }
        public string MapType { get; set; } = "Mix"; // Default type is Mix
        public bool ShowInReport { get; set; } = true;
                              
    }
}
