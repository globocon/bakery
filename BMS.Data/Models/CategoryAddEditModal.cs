
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMS.Data.Models
{
    public class CategoryAddEditModal
    {
        [Required(ErrorMessage = "Category Id is required.")]
        [DisplayName("Category Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Preparation Team is required.")]
        [DisplayName("Preparation Team")]
        public int PreparationTeamId { get; set; }        
    }
}
