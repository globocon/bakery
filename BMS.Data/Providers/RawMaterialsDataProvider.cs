
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IRawMaterialsDataProvider
    {
        // Define methods for product data retrieval, e.g.:
        Task<List<RawMaterial>> GetRawMaterials();
        // Task<Product> GetProductById(int id);
        // Task AddProduct(Product product);
        // Task UpdateProduct(Product product);
        // Task DeleteProduct(int id);
    }
    public class RawMaterialsDataProvider : IRawMaterialsDataProvider
    {
        private readonly IDbService _dbService;

        public RawMaterialsDataProvider(IDbService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }
        public async Task<List<RawMaterial>> GetRawMaterials()
        {
            return await _dbService.GetRawMaterials();
        }
    }
}
