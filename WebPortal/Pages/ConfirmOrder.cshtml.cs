using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class ConfirmOrderModel : PageModel
    {
        private readonly IOrderDataProvider _orderDataProvider;

        public ConfirmOrderModel(IOrderDataProvider orderDataProvider)
        {
            _orderDataProvider = orderDataProvider;
        }

        [BindProperty(SupportsGet = true)]
        public DateTime? SelectedOrderDate { get; set; }

        [BindProperty]
        public List<Order> Orders { get; set; } = new();

        [BindProperty]
        public List<int> SelectedOrderIds { get; set; } = new();

        public async Task OnGet()
        {
            if (SelectedOrderDate.HasValue)
            {
                Orders = await _orderDataProvider.GetOrdersByDateAsync(SelectedOrderDate.Value);
            }
        }

        public async Task<IActionResult> OnPostConfirmOrdersAsync()
        {
            if (SelectedOrderIds != null && SelectedOrderIds.Count > 0)
            {
                await _orderDataProvider.ConfirmOrdersAsync(SelectedOrderIds);
                TempData["NotifyMsg"] = "Selected orders confirmed successfully.";
                TempData["NotifyType"] = "success";
            }
            else
            {
                TempData["NotifyMsg"] = "No orders selected.";
                TempData["NotifyType"] = "warning";
            }

            // Redirect to GET with the same date to refresh the list
            return RedirectToPage(new { OrderDate = SelectedOrderDate?.ToString("yyyy-MM-dd") });
        }
    }
}