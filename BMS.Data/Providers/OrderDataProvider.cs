
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IOrderDataProvider
    { 
        Task<List<Order>> GetOrders();
        Task<List<Product>> GetAllActiveProducts();
        Task<List<Customer>> GetAllActiveCustomers();

    }
    public class OrderDataProvider : IOrderDataProvider
    {

        private readonly IDbService _dbService;
        private readonly IProductsDataProvider _productsDataProvider;
        private readonly ICustomerDataProvider _customerDataProvider;

        public OrderDataProvider(IDbService dbService, IProductsDataProvider productsDataProvider, ICustomerDataProvider customerDataProvider)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _productsDataProvider = productsDataProvider ?? throw new ArgumentNullException(nameof(productsDataProvider));
            _customerDataProvider = customerDataProvider ?? throw new ArgumentNullException(nameof(customerDataProvider));
        }

        public async Task<List<Customer>> GetAllActiveCustomers()
        {
            return await _customerDataProvider.GetCustomers();
        }

        public async Task<List<Product>> GetAllActiveProducts()
        {
            return await _productsDataProvider.GetProducts();
        }

        public Task<List<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
