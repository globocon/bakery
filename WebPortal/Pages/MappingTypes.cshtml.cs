
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class MappingTypesModel : PageModel
    {
        private readonly IProductRawMaterialMapTypeDataProvider _productRawMaterialMapTypeDataProvider;
 
        public MappingTypesModel(IProductRawMaterialMapTypeDataProvider productRawMaterialMapTypeDataProvider)
        {
            _productRawMaterialMapTypeDataProvider = productRawMaterialMapTypeDataProvider;
        }
               
                
        public async Task OnGet()
        {
            
        }

        public async Task<IActionResult> OnGetShowAllProductRawMaterialMapTypeAsync()
        {
            var result = await _productRawMaterialMapTypeDataProvider.GetProductRawMaterialMapTypes();           
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateProductRawMaterialMapTypeAsync(ProductRawMaterialMapTypeAddEditModal MappingtypeAddEditModal)
        {
            var status = true;
            var msg = "Mapping Type updated successfully.";

            try
            {
                if (!ModelState.IsValid)
                {
                    //var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => string.Join(',', $"{x.Value.Errors.Select(y => y.ErrorMessage).ToString().Replace(".","")} for {x.Value.(x=> x. )}."));
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }

                await _productRawMaterialMapTypeDataProvider.UpdateProductRawMaterialMapType(MappingtypeAddEditModal); 

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveProductRawMaterialMapTypeAsync(ProductRawMaterialMapTypeAddEditModal MappingtypeAddEditModal)
        {
            var status = true;
            var msg = "Mapping Type added successfully.";

            try
            {
                if (!ModelState.IsValid)
                {
                    //var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => string.Join(',', $"{x.Value.Errors.Select(y => y.ErrorMessage).ToString().Replace(".","")} for {x.Value.(x=> x. )}."));
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }

                await _productRawMaterialMapTypeDataProvider.AddProductRawMaterialMapType(MappingtypeAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteProductRawMaterialMapTypeAsync(int id)
        {
            var status = true;
            var msg = "Mapping Type deleted successfully.";

            try
            {
                await _productRawMaterialMapTypeDataProvider.DeleteProductRawMaterialMapType(id);
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