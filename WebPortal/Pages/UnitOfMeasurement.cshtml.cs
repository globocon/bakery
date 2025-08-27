
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class UnitOfMeasurementModel : PageModel
    {
        private readonly IUomDataProvider _uomDataProvider;
 
        public UnitOfMeasurementModel(IUomDataProvider uomDataProvider)
        {
           _uomDataProvider = uomDataProvider;
        }
                               
        public async Task OnGet()
        {
            
        }

        public async Task<IActionResult> OnGetShowAllUomAsync()
        {
            var result = await _uomDataProvider.GetUomsConverted();           
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateUomAsync(UomAddEditModal UomAddEditModal)
        {
            var status = true;
            var msg = "Uom updated successfully.";

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

                await _uomDataProvider.UpdateUom(UomAddEditModal); 

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error: {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveUomAsync(UomAddEditModal UomAddEditModal)
        {
            var status = true;
            var msg = "Uom added successfully.";

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

                await _uomDataProvider.AddUom(UomAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error: {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteUomAsync(int id)
        {
            var status = true;
            var msg = "Uom deleted successfully.";

            try
            {
                await _uomDataProvider.DeleteUom(id);
            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error: {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
               
                
    }
}