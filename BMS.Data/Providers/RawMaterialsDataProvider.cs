
using AutoMapper;
using BMS.Data.Entity;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface IRawMaterialsDataProvider
    {
        // Define methods for Ingredient data retrieval, e.g.:
        Task<List<IngredientAddEditModal>> GetRawMaterialsConverted();
        Task<List<RawMaterial>> GetRawMaterials();
        Task UpdateRawMaterial(IngredientAddEditModal ingredientAddEditModal);
        Task AddRawMaterial(IngredientAddEditModal ingredientAddEditModal);
        Task DeleteRawMaterial(int id);
        
    }
    public class RawMaterialsDataProvider : IRawMaterialsDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RawMaterialsDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public async Task<List<IngredientAddEditModal>> GetRawMaterialsConverted()
        {
            var r = await _dbService.GetRawMaterials();
            var rl = _mapper.Map<List<IngredientAddEditModal>>(r);
            return rl;
        }

        public async Task<List<RawMaterial>> GetRawMaterials()
        {
            var r = await _dbService.GetRawMaterials();
            return r;
        }

        public async Task UpdateRawMaterial(IngredientAddEditModal ingredientAddEditModal)
        {
            if (ingredientAddEditModal == null)
            {
                throw new ArgumentNullException(nameof(ingredientAddEditModal));
            }
            var existingIngredient = await _dbService.GetRawMaterialById(ingredientAddEditModal.Id);
            if (existingIngredient == null)
            {
                throw new ArgumentException($"Ingredient with ID {ingredientAddEditModal.Id} not found.");
            }
            var similarIngredient = await _dbService.GetRawMaterialByName(ingredientAddEditModal.IngredientName);
            if (similarIngredient != null && similarIngredient.RawMaterialId != ingredientAddEditModal.Id)
            {
                throw new ArgumentException($"Ingredient with name {ingredientAddEditModal.IngredientName} already exists.");
            }
            _mapper.Map(ingredientAddEditModal, existingIngredient);
            if (ingredientAddEditModal.PhyStockQty != 0)
            {
                existingIngredient.StockQuantity = ingredientAddEditModal.PhyStockQty;
                // also need to pass entry into adjustments tables.
            }
            await _dbService.UpdateRawMaterial(existingIngredient);
            return;
        }

        public async Task AddRawMaterial(IngredientAddEditModal ingredientAddEditModal)
        {
            if (ingredientAddEditModal == null)
            {
                throw new ArgumentNullException(nameof(ingredientAddEditModal));
            }
            var existingProduct = await _dbService.GetRawMaterialByName(ingredientAddEditModal.IngredientName);
            if (existingProduct != null)
            {
                throw new ArgumentException($"Ingredient with name {ingredientAddEditModal.IngredientName} already exists.");
            }

            var ingredientEntity = _mapper.Map<RawMaterial>(ingredientAddEditModal);
            ingredientEntity.StockQuantity = ingredientAddEditModal.PhyStockQty;
            ingredientEntity.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            ingredientEntity.CreatedOn = DateTime.UtcNow; // Set creation date to now
            await _dbService.AddRawMaterial(ingredientEntity);
            return;
        }

        public async Task DeleteRawMaterial(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Invalid ingredient id.");
            }
            var existingProduct = await _dbService.GetRawMaterialById(id);
            if (existingProduct == null)
            {
                throw new ArgumentException($"Ingredient not found.");
            }

            await _dbService.DeleteRawMaterial(id);
        }
    }
}
