

namespace BMS.Data.Models
{
    public class OrderNewEdit
    {        
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public int? InvoiceRefId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }             
        public ICollection<OrderItemNewEdit> OrderItems { get; set; }
    }

    public class OrderItemNewEdit
    {        
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
    }
}
