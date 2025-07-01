using iText.Layout.Borders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Data.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? InvoiceRefId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Invoice? Invoice { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? DeliveryDateTime { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
