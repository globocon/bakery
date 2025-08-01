using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BMS.Data.Models
{
    public class ProductAddEditModal
    {
        [Required(ErrorMessage = "Product Id is required.")]
        [DisplayName("Product Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product category is required.")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Mrp of the product is required.")]   
        [DisplayName("MRP")]
        public decimal MRP { get; set; }
        //public string? ImgFileExtn { get; set; }    
    }
}
