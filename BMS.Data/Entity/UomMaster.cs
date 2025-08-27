using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entity
{
    public class UomMaster
    {
        [Key]
        public int Id { get; set; }
        public string UOMName { get; set; }  
    }
}
