using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Enums
{
    public enum TranHistEnum
    {
        [Display(Name = "Opening Stock")]
        OPENING_STOCK = 1,

        [Display(Name = "Stock Adjustment")]
        STOCK_ADJUSTMENT = 2,

        [Display(Name = "Stock In")]
        STOCK_IN = 3,

        [Display(Name = "Stock Out")]
        STOCK_OUT = 4,

        [Display(Name = "Order Processed")]
        STOCK_ORDER_PROCESSED = 5,
    }
}
