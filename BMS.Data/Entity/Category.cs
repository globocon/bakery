using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMS.Data.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("PreparationTeam")]
        public int PreparationTeamId { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public int Sort_Order { get; set; } = 0;

        public PreparationTeam PreparationTeam { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}
