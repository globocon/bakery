using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages
{
    public class TeamsModel : PageModel
    {
        private readonly ITeamsDataProvider _teamsDataProvider;
        public TeamsModel(ITeamsDataProvider teamsDataProvider)
        {
            _teamsDataProvider = teamsDataProvider ?? throw new ArgumentNullException(nameof(teamsDataProvider));
        }

        
        public async Task OnGet()
        {
            
        }

        public async Task<IActionResult> OnGetShowAllTeamAsync()
        {
            var result = await _teamsDataProvider.GetTeamsConverted();
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateTeamAsync(PreparationTeamAddEditModal PreparationTeamAddEditModal)
        {
            var status = true;
            var msg = "Team updated successfully.";

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

                await _teamsDataProvider.UpdateTeam(PreparationTeamAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error: {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveTeamAsync(PreparationTeamAddEditModal PreparationTeamAddEditModal)
        {
            var status = true;
            var msg = "Team added successfully.";

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

                await _teamsDataProvider.AddTeam(PreparationTeamAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error: {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteTeamAsync(int id)
        {
            var status = true;
            var msg = "Team deleted successfully.";

            try
            {
                await _teamsDataProvider.DeleteTeam(id);
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
