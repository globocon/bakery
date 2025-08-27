using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entity
{
    public class PreparationTeam
    {
        [Key]
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        public ICollection<Category> Categories { get; set; }
    }
}
