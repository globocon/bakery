using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IProductIngredientsDataProvider
    {
        Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingListAsync();
        Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingByProductIdAsync(int ProductId);
        Task<ProductRawMaterial?> GetProductRawMaterialMappingByIdAsync(int id);
        Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialIdAsync(int ProductId, int RawMaterialId);
        Task AddProductRawMaterialMappingAsync(ProductRawMaterial ingredient);
        Task UpdateProductRawMaterialMappingAsync(ProductRawMaterial ingredient);
        Task DeleteProductRawMaterialMappingAsync(int Id);
    }

    public class ProductIngredientsDataProvider : IProductIngredientsDataProvider
    {
        private readonly IDbService _dbService;

        public ProductIngredientsDataProvider(IDbService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }

        public async Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingListAsync()
        {
            return await _dbService.GetAllProductRawMaterialsMappingList();
        }

        public async Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingByProductIdAsync(int ProductId)
        {
            return await _dbService.GetProductRawMaterialsMappingByProductId(ProductId);
        }

        public async Task<ProductRawMaterial?> GetProductRawMaterialMappingByIdAsync(int id)
        {
            return await _dbService.GetProductRawMaterialMappingById(id);
        }

        public async Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialIdAsync(int ProductId, int RawMaterialId)
        {
            return await _dbService.GetProductRawMaterialMappingByProductIdAndRawMaterialId(ProductId, RawMaterialId);
        }

        public async Task AddProductRawMaterialMappingAsync(ProductRawMaterial ingredient)
        {
            // Check if mapping already exists
            var r = await _dbService.GetProductRawMaterialMappingByProductIdAndRawMaterialIdAndMapType(ingredient.ProductId, ingredient.RawMaterialId, ingredient.MapType);
            if (r != null) { throw new Exception($"Product and ingredient mapping already exists."); }
            await _dbService.AddProductRawMaterialMapping(ingredient);
        }

        public async Task UpdateProductRawMaterialMappingAsync(ProductRawMaterial ingredient)
        {
            // Check if mapping already exists
            var r = await _dbService.GetProductRawMaterialMappingByProductIdAndRawMaterialId(ingredient.ProductId, ingredient.RawMaterialId);
            if (r != null && r.Id != ingredient.Id) { throw new Exception($"Another Product and ingredient mapping already exists."); }

            var toupdate = await _dbService.GetProductRawMaterialMappingById(ingredient.Id);
            if (toupdate != null)
            {
                toupdate.ProductId = ingredient.ProductId;
                toupdate.RawMaterialId = ingredient.RawMaterialId;
                toupdate.QuantityRequired = ingredient.QuantityRequired;
                await _dbService.UpdateProductRawMaterialMapping(toupdate);
            }
            else
            {
                throw new Exception($"Product and ingredient mapping not found.");
            }
        }

        public async Task DeleteProductRawMaterialMappingAsync(int Id)
        {
            await _dbService.DeleteProductRawMaterialMapping(Id);
            return;
        }
    }
}