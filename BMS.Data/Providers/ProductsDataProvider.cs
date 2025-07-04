
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IProductsDataProvider
    {
        // Define methods for product data retrieval, e.g.:
        Task<List<Product>> GetProducts();
        // Task<Product> GetProductById(int id);
        // Task AddProduct(Product product);
        // Task UpdateProduct(Product product);
        // Task DeleteProduct(int id);
    }
    public class ProductsDataProvider : IProductsDataProvider
    {
        private readonly IDbService _dbService;

        public ProductsDataProvider(IDbService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _dbService.GetProducts();
        }
    }
}
