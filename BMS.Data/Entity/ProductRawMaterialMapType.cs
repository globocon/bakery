using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entity
{
    public class ProductRawMaterialMapType
    {
        [Key]
        public int Id { get; set; }
        public string MapTypeName { get; set; }  
    }
}
