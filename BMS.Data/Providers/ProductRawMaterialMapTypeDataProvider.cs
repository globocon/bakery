using AutoMapper;
using BMS.Data.Entity;
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IProductRawMaterialMapTypeDataProvider
    {
        Task<List<ProductRawMaterialMapTypeAddEditModal>> GetProductRawMaterialMapTypes();
        Task<ProductRawMaterialMapTypeAddEditModal?> GetProductRawMaterialMapTypeById(int id);        
        Task AddProductRawMaterialMapType(ProductRawMaterialMapTypeAddEditModal prmmt);
        Task UpdateProductRawMaterialMapType(ProductRawMaterialMapTypeAddEditModal prmmt);
        Task DeleteProductRawMaterialMapType(int id);
    }

    public class ProductRawMaterialMapTypeDataProvider : IProductRawMaterialMapTypeDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public ProductRawMaterialMapTypeDataProvider(IDbService dbService, IMapper mapper)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<ProductRawMaterialMapTypeAddEditModal>> GetProductRawMaterialMapTypes()
        {
            var r = await _dbService.GetProductRawMaterialMapTypes();
            var rl = _mapper.Map<List<ProductRawMaterialMapTypeAddEditModal>>(r);
            return rl;            
        }

        public async Task<ProductRawMaterialMapTypeAddEditModal?> GetProductRawMaterialMapTypeById(int id)
        {
            var r = await _dbService.GetProductRawMaterialMapTypeById(id);
            var rl = _mapper.Map<ProductRawMaterialMapTypeAddEditModal>(r);
            return rl;
        }
                
        public async Task AddProductRawMaterialMapType(ProductRawMaterialMapTypeAddEditModal prmmt)
        {
            if (prmmt == null)
                throw new ArgumentNullException(nameof(prmmt));

            var newPrmmt = _mapper.Map<ProductRawMaterialMapType>(prmmt);            
            await _dbService.AddProductRawMaterialMapType(newPrmmt);
        }

        public async Task UpdateProductRawMaterialMapType(ProductRawMaterialMapTypeAddEditModal prmmt)
        {           
            if (prmmt == null)
            {
                throw new ArgumentNullException(nameof(prmmt));
            }
            var existing = await _dbService.GetProductRawMaterialMapTypeById(prmmt.Id);
            if (existing == null)
            {
                throw new ArgumentException($"Mapping Type with ID {prmmt.Id} not found.");
            }
            var similarIngredient = await _dbService.GetProductRawMaterialMapTypeByName(prmmt.MapTypeName);
            if (similarIngredient != null && similarIngredient.Id != prmmt.Id)
            {
                throw new ArgumentException($"Mapping Type with name {prmmt.MapTypeName} already exists.");
            }
            _mapper.Map(prmmt, existing);
            
            await _dbService.UpdateProductRawMaterialMapType(existing);
            return;
        }

        public async Task DeleteProductRawMaterialMapType(int id)
        {
            await _dbService.DeleteProductRawMaterialMapType(id);
        }
    }
}



