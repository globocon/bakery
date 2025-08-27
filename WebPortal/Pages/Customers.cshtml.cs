using BMS.Data.Entity;
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly ICustomerDataProvider _customerDataProvider;
        private string uploadsFolder;
        public CustomersModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider ?? throw new ArgumentNullException(nameof(customerDataProvider));
            uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "Customers");
        }

        //[BindProperty]
        //public List<CustomerAddEditModal> Customers { get; set; }
        //[BindProperty]
        //public Customer NewCustomer { get; set; }
        public async Task OnGet()
        {
            //Customers = await _customerDataProvider.GetCustomersConverted();
            //NewCustomer = new Customer();
        }

        public async Task<IActionResult> OnGetShowAllCustomerAsync()
        {
            var result = await _customerDataProvider.GetCustomersConverted();
            return new JsonResult(result);
        }

        public async Task<IActionResult> OnGetFetchCustomerByIdAsync(int id)
        {
            var result = await _customerDataProvider.GetCustomerAddEditModalById(id);
            return new JsonResult(result);
        }
              

        public async Task<JsonResult> OnPostUpdateCustomerAsync(CustomerAddEditModal customerAddEditModal, IFormFile CustomerImage)
        {
            var status = true;
            var msg = "Customer Updated Successfully.";

            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }
                                
                if (CustomerImage != null && CustomerImage.Length > 0)
                {                    
                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder);

                    var fileExtn = Path.GetExtension(CustomerImage.FileName);
                    var fileName = $"{customerAddEditModal.CustomerId}{fileExtn}";
                    var filePath = Path.Combine(uploadsFolder, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await CustomerImage.CopyToAsync(stream);
                    }

                    // Save image path to DB field
                    customerAddEditModal.ImgFileExtn = fileExtn;
                }

                // Save/update to DB
                await _customerDataProvider.UpdateCustomer(customerAddEditModal);
            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveCustomerAsync(CustomerAddEditModal customerAddEditModal, IFormFile CustomerImage)
        {
            var status = true;
            var msg = "Customer Added Successfully.";

            try
            {
                if (!ModelState.IsValid)
                {                    
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }

                var customer_created = await _customerDataProvider.AddCustomer(customerAddEditModal);
                var new_customer_ID = customer_created.CustomerId;
                if (CustomerImage != null && CustomerImage.Length > 0)
                {                    
                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder);

                    var fileExtn = Path.GetExtension(CustomerImage.FileName);
                    var fileName = $"{new_customer_ID}{fileExtn}";
                    var filePath = Path.Combine(uploadsFolder, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await CustomerImage.CopyToAsync(stream);
                    }

                    // Save image path to DB field
                    await _customerDataProvider.UpdateCustomerImage(new_customer_ID, fileExtn);
                }

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteCustomerAsync(int id)
        {
            var status = true;
            var msg = "Customer Deleted Successfully.";

            try
            {
                await _customerDataProvider.DeleteCustomer(id);
            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
    }
}
