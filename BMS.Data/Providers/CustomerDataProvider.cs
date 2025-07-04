
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface ICustomerDataProvider
    { 
        public Task<List<Customer>> GetCustomers();
    }
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public readonly IDbService _dbService;

        public CustomerDataProvider(IDbService dbService)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
        }
        public async Task<List<Customer>> GetCustomers()
        {
            return await _dbService.GetCustomers();
        }
    }
}
