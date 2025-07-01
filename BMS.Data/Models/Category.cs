
using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }

        public PreparationTeam PreparationTeam { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
