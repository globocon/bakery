
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface ITeamsDataProvider
    { 
        public Task<List<PreparationTeam>> GetTeams();
    }
    public class TeamsDataProvider : ITeamsDataProvider
    {
        public readonly IDbService _dbService;

        public TeamsDataProvider(IDbService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }
        public async Task<List<PreparationTeam>> GetTeams()
        {
            return await _dbService.GetTeams();
        }
    }
}
