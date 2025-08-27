
using AutoMapper;
using BMS.Data.Entity;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface ITeamsDataProvider
    { 
        public Task<List<PreparationTeam>> GetTeams();
        Task<List<PreparationTeamAddEditModal>> GetTeamsConverted();
        Task<PreparationTeam?> GetTeamById(int id);
        Task<PreparationTeamAddEditModal?> GetTeamAddEditModalById(int id);
        Task AddTeam(PreparationTeamAddEditModal category);
        Task UpdateTeam(PreparationTeamAddEditModal category);
        Task DeleteTeam(int id);
    }
    public class TeamsDataProvider : ITeamsDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TeamsDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public async Task<List<PreparationTeam>> GetTeams()
        {
            return await _dbService.GetTeams();
        }
        public async Task<List<PreparationTeamAddEditModal>> GetTeamsConverted()
        {
            var r = await _dbService.GetTeams();
            if (r == null)
                return null;

            return _mapper.Map<List<PreparationTeamAddEditModal>>(r);
        }
        public async Task<PreparationTeam?> GetTeamById(int id)
        {
            return await _dbService.GetTeamById(id);
        }

        public async Task<PreparationTeamAddEditModal?> GetTeamAddEditModalById(int id)
        {
            var r = await _dbService.GetCategoryById(id);
            if (r == null)
                return null;

            return _mapper.Map<PreparationTeamAddEditModal>(r);
        }

        public async Task AddTeam(PreparationTeamAddEditModal preparationTeam)
        {
            if (preparationTeam == null)
                throw new ArgumentNullException(nameof(preparationTeam));

            PreparationTeam newPreparationTeam = _mapper.Map<PreparationTeam>(preparationTeam);
            newPreparationTeam.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            newPreparationTeam.CreatedOn = DateTime.UtcNow;
            newPreparationTeam.IsDeleted = false;
            await _dbService.AddTeam(newPreparationTeam);
        }

        public async Task UpdateTeam(PreparationTeamAddEditModal preparationTeam)
        {
            var existing = await _dbService.GetTeamById(preparationTeam.Id);
            if (existing != null)
            {
                existing.TeamName = preparationTeam.TeamName;
                await _dbService.UpdateTeam(existing);
            }
        }

        public async Task DeleteTeam(int id)
        {
            await _dbService.DeleteTeam(id);
        }
    }
}
