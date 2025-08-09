using AutoMapper;
using BMS.Data.Helpers;
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
        Task AddProductRawMaterialMappingAsync(ProductRawMaterialAddModal ingredient);
        Task UpdateProductRawMaterialMappingAsync(ProductRawMaterialAddModal ingredient);
        Task DeleteProductRawMaterialMappingAsync(int Id);

        Task<List<ProductRawMaterialMapType>> GetAllProductRawMaterialMapTypeListAsync();
        Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeByIdAsync(int id);
    }

    public class ProductIngredientsDataProvider : IProductIngredientsDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public ProductIngredientsDataProvider(IDbService dbService, IMapper mapper)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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

        public async Task AddProductRawMaterialMappingAsync(ProductRawMaterialAddModal ingredient)
        {

            if (ingredient == null)
                throw new ArgumentNullException(nameof(ingredient));
                        
            // Check if mapping already exists
            var r = await _dbService.GetProductRawMaterialMappingByProductIdAndRawMaterialIdAndMapType(ingredient.ProductId, ingredient.RawMaterialId, ingredient.MapType);
            if (r != null) { throw new Exception($"Product and ingredient mapping already exists."); }
            ProductRawMaterial newMapping = _mapper.Map<ProductRawMaterial>(ingredient);
            await _dbService.AddProductRawMaterialMapping(newMapping);
        }

        public async Task UpdateProductRawMaterialMappingAsync(ProductRawMaterialAddModal ingredient)
        {
            // Check if mapping already exists
            var r = await _dbService.GetProductRawMaterialMappingByProductIdAndRawMaterialIdAndMapType(ingredient.ProductId, ingredient.RawMaterialId, ingredient.MapType);
            if (r != null && r.Id != ingredient.Id) { throw new Exception($"Same Product and ingredient mapping already exists."); }

            var toupdate = await _dbService.GetProductRawMaterialMappingById(ingredient.Id);
            if (toupdate != null)
            {
                toupdate.ProductId = ingredient.ProductId;
                toupdate.RawMaterialId = ingredient.RawMaterialId;
                toupdate.QuantityRequired = ingredient.QuantityRequired;
                toupdate.MapType = ingredient.MapType;
                toupdate.ShowInReport = ingredient.ShowInReport;
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

        public async Task<List<ProductRawMaterialMapType>> GetAllProductRawMaterialMapTypeListAsync()
        {
            return await _dbService.GetProductRawMaterialMapType();
        }

        public async Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeByIdAsync(int id)
        {
            return await _dbService.GetProductRawMaterialMapTypeById(id);
        }
    }
}