using BMS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entity
{
    public class TranHist
    {
        [Key]
        public long TranHistId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public TranHistEnum TranTypeId { get; set; }
        public float Quantity { get; set; }
        public decimal CP { get; set; }
        public string Unit { get; set; }
        public string CreatedById { get; set; }

    }
}
