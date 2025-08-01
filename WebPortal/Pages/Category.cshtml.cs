using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly ITeamsDataProvider _teamsDataProvider;

        public CategoryModel(ICategoryDataProvider categoryDataProvider, ITeamsDataProvider teamsDataProvider)
        {
            _categoryDataProvider = categoryDataProvider;
            _teamsDataProvider = teamsDataProvider;
        }
               
        public List<Category> Categories { get; set; } = new();
        public List<PreparationTeam> Teams { get; set; } = new();

        public async Task OnGet(int? id)
        {
            Categories = await _categoryDataProvider.GetCategories();
            Teams = await _teamsDataProvider.GetTeams();
        }

        public async Task<IActionResult> OnGetShowAllCategoriesAsync()
        {
            var result = await _categoryDataProvider.GetCategories();
            //Code to avoid recrussive json result
            if (result != null)
            {
                result.ForEach(p =>
                {
                    p.Products = null;
                    p.PreparationTeam.Categories = null;
                });
            }
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateCategoryAsync(CategoryAddEditModal categoryAddEditModal)
        {
            var status = true;
            var msg = "Category Updated Successfully.";

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

                await _categoryDataProvider.UpdateCategory(categoryAddEditModal); 

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveCategoryAsync(CategoryAddEditModal categoryAddEditModal)
        {
            var status = true;
            var msg = "Category Added Successfully.";

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

                await _categoryDataProvider.AddCategory(categoryAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteCategoryAsync(int id)
        {
            var status = true;
            var msg = "Category Deleted Successfully.";

            try
            {
                await _categoryDataProvider.DeleteCategory(id);
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