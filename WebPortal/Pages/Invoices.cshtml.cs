using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BMS.Data.Models;
using BMS.Data.Providers;

namespace WebPortal.Pages
{
    public class InvoicesModel : PageModel
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private readonly IInvoiceDataProvider _invoiceDataProvider;

        public InvoicesModel(ICustomerDataProvider customerDataProvider, IInvoiceDataProvider invoiceDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            _invoiceDataProvider = invoiceDataProvider;
        }

        public List<Customer> Customers { get; set; } = new();

        public void OnGet()
        {
            Customers = _customerDataProvider.GetCustomers().Result;
        }

        public async Task<JsonResult> OnPostGenerateInvoiceAsync([FromBody] InvoiceRequestModel request)
        {
            if (request == null || request.CustomerId == 0 || request.InvoiceDate == default)
                return new JsonResult(new { success = false, message = "Invalid input." });

            var invoice = await _invoiceDataProvider.GenerateInvoiceAsync(request.CustomerId, request.InvoiceDate);

            if (invoice == null)
                return new JsonResult(new { success = false, message = "Failed to generate invoice." });

            invoice.Customer.Orders = null;

            return new JsonResult(new { success = true, invoice });
        }

        public async Task<IActionResult> OnGetDownloadInvoicePdfAsync(int customerId, DateTime invoiceDate)
        {
            var pdfBytes = await _invoiceDataProvider.GenerateInvoicePdfAsync(customerId, invoiceDate);
            if (pdfBytes == null || pdfBytes.Length == 0)
                return NotFound();

            var fileName = $"Invoice_{customerId}_{invoiceDate:yyyyMMdd}.pdf";
            return File(pdfBytes, "application/pdf", fileName);
        }
    }
}
