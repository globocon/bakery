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

        [BindProperty]
        public List<PreparationTeam> Teams { get; set; }
        [BindProperty]
        public PreparationTeam NewTeams { get; set; }
        public async Task OnGet()
        {
            Teams = await _teamsDataProvider.GetTeams();
            NewTeams = new PreparationTeam();
        }
    }
}
