
using System.ComponentModel.DataAnnotations;


namespace BMS.Data.Models
{
    public class USR_Users
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Display(Name = "Login Id")]
        public string LoginId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsDeleted { get; set; } = false;
        public string? ImgFileExtn { get; set; }
    }

    public class USR_Login
    {
        [Required]
        [Display(Name = "Login Id")]
        public string LoginId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
