using AutoMapper;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface ICategoryDataProvider
    {
        Task<List<Category>> GetCategories();
        Task<Category?> GetCategoryById(int id);
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int id);
    }

    public class CategoryDataProvider : ICategoryDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoryDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _dbService.GetCategories();
        }

        public async Task<Category?> GetCategoryById(int id)
        {
            return await _dbService.GetCategoryById(id);
        }

        public async Task AddCategory(Category category)
        {
            category.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            category.CreatedOn = DateTime.UtcNow;
            category.IsDeleted = false;
            await _dbService.AddCategory(category);
        }

        public async Task UpdateCategory(Category category)
        {
            var existing = await _dbService.GetCategoryById(category.Id);
            if (existing != null)
            {
                existing.Name = category.Name;
                existing.PreparationTeamId = category.PreparationTeamId;
                // Optionally update other fields
                await _dbService.UpdateCategory(existing);
            }
        }

        public async Task DeleteCategory(int id)
        {
            await _dbService.DeleteCategory(id);
        }
    }
}



