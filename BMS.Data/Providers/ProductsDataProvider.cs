
using AutoMapper;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface IProductsDataProvider
    {
        // Define methods for product data retrieval, e.g.:
        Task<List<Product>> GetProducts();
        // Task<Product> GetProductById(int id);
        Task AddProduct(ProductAddEditModal product);
        Task UpdateProduct(ProductAddEditModal product);
        Task DeleteProduct(int id);
    }
    public class ProductsDataProvider : IProductsDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductsDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        

        public async Task<List<Product>> GetProducts()
        {
            return await _dbService.GetProducts();
        }

        public async Task UpdateProduct(ProductAddEditModal productAddEditModal)
        {
            if (productAddEditModal == null)
            {
                throw new ArgumentNullException(nameof(productAddEditModal));
            }
            var existingProduct = await _dbService.GetProductById(productAddEditModal.Id);
            if (existingProduct == null)
            {
                throw new ArgumentException($"Product with ID {productAddEditModal.Id} not found.");
            }


            //var productEntity = _mapper.Map<Product>(productAddEditModal);

            _mapper.Map(productAddEditModal, existingProduct);            
            await _dbService.UpdateProduct(existingProduct);
            return;
        }

        public async Task AddProduct(ProductAddEditModal productAddEditModal)
        {
            if (productAddEditModal == null)
            {
                throw new ArgumentNullException(nameof(productAddEditModal));
            }
            var existingProduct = await _dbService.GetProductByName(productAddEditModal.ProductName);
            if (existingProduct != null)
            {
                throw new ArgumentException($"Product with name {productAddEditModal.ProductName} already exists.");
            }

            var productEntity = _mapper.Map<Product>(productAddEditModal);
            productEntity.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            productEntity.CreatedOn = DateTime.UtcNow; // Set creation date to now
            await _dbService.AddProduct(productEntity);
            return;
        }

        public async Task DeleteProduct(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Invalid product ID.");
            }
            var existingProduct = await _dbService.GetProductById(id);
            if (existingProduct == null)
            {
                throw new ArgumentException($"Product not found.");
            }

            await _dbService.DeleteProduct(id);
        }
    }
}
