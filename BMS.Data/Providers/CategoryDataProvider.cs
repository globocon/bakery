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
        Task<CategoryAddEditModal?> GetCategoryAddEditModalById(int id);
        Task AddCategory(CategoryAddEditModal category);
        Task UpdateCategory(CategoryAddEditModal category);
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

        public async Task<CategoryAddEditModal?> GetCategoryAddEditModalById(int id)
        {
            var r = await _dbService.GetCategoryById(id);
            if (r == null)
                return null;

            return _mapper.Map<CategoryAddEditModal>(r);
        }

        public async Task AddCategory(CategoryAddEditModal category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            Category newCategory = _mapper.Map<Category>(category);
            newCategory.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            newCategory.CreatedOn = DateTime.UtcNow;
            newCategory.IsDeleted = false;
            await _dbService.AddCategory(newCategory);
        }

        public async Task UpdateCategory(CategoryAddEditModal category)
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



