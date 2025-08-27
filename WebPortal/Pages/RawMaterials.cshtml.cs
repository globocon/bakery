using BMS.Data.Entity;
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebPortal.Pages
{
    public class RawMaterialsModel : PageModel
    {
        private readonly IRawMaterialsDataProvider _rawMaterialsDataProvider;
        private readonly IUomDataProvider _uomDataProvider;
        public RawMaterialsModel(IRawMaterialsDataProvider rawMaterialsDataProvider, IUomDataProvider uomDataProvider)
        {
            _rawMaterialsDataProvider = rawMaterialsDataProvider;
            _uomDataProvider = uomDataProvider;
        }

        //public List<IngredientAddEditModal> RawMaterials { get; set; } = new();
        public List<UomMaster> UomMasters { get; set; } = new();

        public async Task OnGet()
        {
            //RawMaterials = await _rawMaterialsDataProvider.GetRawMaterials();
            UomMasters = await _uomDataProvider.GetUoms();
        }

        public async Task<IActionResult> OnGetShowAllIngredientAsync()
        {
            var result = await _rawMaterialsDataProvider.GetRawMaterialsConverted();
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateIngredientAsync(IngredientAddEditModal ingredientAddEditModal)
        {
            var status = true;
            var msg = "Ingredient Updated Successfully.";

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

                await _rawMaterialsDataProvider.UpdateRawMaterial(ingredientAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveIngredientAsync(IngredientAddEditModal ingredientAddEditModal)
        {
            var status = true;
            var msg = "Ingredient Added Successfully.";

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

                await _rawMaterialsDataProvider.AddRawMaterial(ingredientAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteIngredientAsync(int id)
        {
            var status = true;
            var msg = "Ingredient Deleted Successfully.";

            try
            {
                await _rawMaterialsDataProvider.DeleteRawMaterial(id);
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