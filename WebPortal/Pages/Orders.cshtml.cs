using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebPortal.Pages
{
    [Authorize]
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
        public List<Product> productsList { get; set; }

        public async Task OnGet()
        {
            Customers = await _orderDataProvider.GetAllActiveCustomers();
            productsList = await _orderDataProvider.GetAllActiveProducts();
        }

        //[IgnoreAntiforgeryToken]
        public async Task<IActionResult> OnPostSaveNewOrderAsync()
        {
            try
            {
                // Read JSON body from request
                using var reader = new StreamReader(Request.Body);
                var body = await reader.ReadToEndAsync();
                if (string.IsNullOrWhiteSpace(body))
                    return new JsonResult(new { message = "No data received." }) { StatusCode = 400 };

                var order = JsonSerializer.Deserialize<OrderNewEdit>(body, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (order == null)
                    return new JsonResult(new { message = "Invalid order data." }) { StatusCode = 400 };

                // Optionally: Validate order fields here

                // Save order using your data provider
                var savedOrderId = await _orderDataProvider.SaveOrderAsync(order);
                if (string.IsNullOrEmpty(savedOrderId))
                    return new JsonResult(new { message = "Failed to save order." }) { StatusCode = 500 };

                return new JsonResult(new { success = true, orderNumber = savedOrderId });
            }
            catch (Exception ex)
            {
                // Log exception as needed
                return new JsonResult(new { message = "Error saving order: " + ex.Message }) { StatusCode = 500 };
            }
        }
                
        public async Task<IActionResult> OnPostSaveSpecialOrderAsync()
        {
            try
            {
                using var reader = new StreamReader(Request.Body);
                var body = await reader.ReadToEndAsync();
                if (string.IsNullOrWhiteSpace(body))
                    return new JsonResult(new { message = "No data received." }) { StatusCode = 400 };

                var order = JsonSerializer.Deserialize<OrderNewEdit>(body, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (order == null)
                    return new JsonResult(new { message = "Invalid order data." }) { StatusCode = 400 };

                // Save order using your data provider
                var savedOrderId = await _orderDataProvider.SaveOrderAsync(order);
                if (string.IsNullOrEmpty(savedOrderId))
                    return new JsonResult(new { message = "Failed to save order." }) { StatusCode = 500 };

                return new JsonResult(new { success = true, orderNumber = savedOrderId });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = "Error saving special order: " + ex.Message }) { StatusCode = 500 };
            }
        }
    }
}
