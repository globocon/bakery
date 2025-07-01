
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class PreparationTeam
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
