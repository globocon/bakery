using AutoMapper;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface ISubCategoryDataProvider
    {
        Task<List<SubCategory>> GetSubCategories();
        Task<SubCategory?> GetSubCategoryById(int id);
        Task AddSubCategory(SubCategory category);
        Task UpdateSubCategory(SubCategory category);
        Task DeleteSubCategory(int id);
    }

    public class SubCategoryDataProvider : ISubCategoryDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SubCategoryDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<List<SubCategory>> GetSubCategories()
        {
            return await _dbService.GetSubCategories();
        }

        public async Task<SubCategory?> GetSubCategoryById(int id)
        {
            return await _dbService.GetSubCategoryById(id);
        }

        public async Task AddSubCategory(SubCategory category)
        {
            category.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            category.CreatedOn = DateTime.UtcNow;
            category.IsDeleted = false;
            await _dbService.AddSubCategory(category);
        }

        public async Task UpdateSubCategory(SubCategory category)
        {
            var existing = await _dbService.GetSubCategoryById(category.Id);
            if (existing != null)
            {
                existing.Name = category.Name;
                existing.CategoryId = category.CategoryId;
                // Optionally update other fields
                await _dbService.UpdateSubCategory(existing);
            }
        }

        public async Task DeleteSubCategory(int id)
        {
            await _dbService.DeleteSubCategory(id);
        }
    }
}



