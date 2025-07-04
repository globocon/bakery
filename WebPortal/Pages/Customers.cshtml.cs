using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        public CustomersModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider ?? throw new ArgumentNullException(nameof(customerDataProvider));
        }

        [BindProperty]
        public List<Customer> Customers { get; set; }
        [BindProperty]
        public Customer NewCustomer { get; set; }
        public async Task OnGet()
        {
            Customers = await _customerDataProvider.GetCustomers();
            NewCustomer = new Customer();
        }
    }
}
