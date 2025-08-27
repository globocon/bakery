
namespace BMS.Data.Models
{
    public class IngredientAddEditModal
    {       
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public float SysStockQty { get; set; }
        public float PhyStockQty { get; set; } = 0;
        public decimal CP { get; set; }
        public string uom { get; set; }        
    }
}
