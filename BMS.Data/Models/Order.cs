using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public int? InvoiceRefId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public DateTime? DeliveryDateTime { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
