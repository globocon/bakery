using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class OrdersModel : PageModel
    {
        
        private readonly IOrderDataProvider _orderDataProvider;
        public OrdersModel(IOrderDataProvider orderDataProvider)
        {
            _orderDataProvider = orderDataProvider ?? throw new ArgumentNullException(nameof(orderDataProvider));
        }

        [BindProperty]
        public List<Customer> Customers { get; set; }
        [BindProperty]
        public List<Product> productsList{ get; set; }
        public async Task OnGet()
        {
            Customers = await _orderDataProvider.GetAllActiveCustomers();
            productsList = await _orderDataProvider.GetAllActiveProducts();
        }

    }
}
