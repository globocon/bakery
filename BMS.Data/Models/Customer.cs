using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? GSTNo { get; set; }
        public string? ImgFileExtn { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;

        public ICollection<Order> Orders { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
