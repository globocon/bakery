using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [BindProperty]
        public List<Category> Categories { get; set; } = new();

        [BindProperty]
        public Category EditCategory { get; set; } = new();

        public List<PreparationTeam> Teams { get; set; } = new();

        public async Task OnGet(int? id)
        {
            Categories = await _categoryDataProvider.GetCategories();
            Teams = await _teamsDataProvider.GetTeams();

            if (id.HasValue)
            {
                var cat = await _categoryDataProvider.GetCategoryById(id.Value);
                EditCategory = cat ?? new Category();
            }
            else
            {
                EditCategory = new Category();
            }
        }

        public async Task<IActionResult> OnPostAddOrEditAsync()
        {
            if (!ModelState.IsValid)
            {
                Categories = await _categoryDataProvider.GetCategories();
                Teams = await _teamsDataProvider.GetTeams();
                return Page();
            }

            if (EditCategory.Id == 0)
                await _categoryDataProvider.AddCategory(EditCategory);
            else
                await _categoryDataProvider.UpdateCategory(EditCategory);

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            await _categoryDataProvider.DeleteCategory(id);
            return RedirectToPage();
        }
    }
}