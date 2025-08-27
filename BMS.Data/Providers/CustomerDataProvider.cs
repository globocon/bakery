
using AutoMapper;
using BMS.Data.Entity;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface ICustomerDataProvider
    { 
        public Task<List<Customer>> GetCustomers();
        public Task<List<CustomerAddEditModal>> GetCustomersConverted();

        Task<Customer?> GetCustomerById(int id);
        Task<CustomerAddEditModal?> GetCustomerAddEditModalById(int id);
        Task<Customer> AddCustomer(CustomerAddEditModal customer);
        Task UpdateCustomer(CustomerAddEditModal customer);
        Task UpdateCustomerImage(int customerid, string fileExtn);
        Task DeleteCustomer(int id);
    }
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomerDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public async Task<List<Customer>> GetCustomers()
        {
            return await _dbService.GetCustomers();
        }
        public async Task<List<CustomerAddEditModal>> GetCustomersConverted()
        {
            var r = await _dbService.GetCustomers();
            var rl = _mapper.Map<List<CustomerAddEditModal>>(r);
            return rl;
        }
        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _dbService.GetCustomerById(id);
        }

        public async Task<CustomerAddEditModal?> GetCustomerAddEditModalById(int id)
        {
            var r = await _dbService.GetCustomerById(id);
            if (r == null)
                return null;

            return _mapper.Map<CustomerAddEditModal>(r);
        }

        public async Task<Customer> AddCustomer(CustomerAddEditModal customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            Customer newCustomer = _mapper.Map<Customer>(customer);
            newCustomer.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            newCustomer.CreatedOn = DateTime.UtcNow;
            newCustomer.IsDeleted = false;
            await _dbService.AddCustomer(newCustomer);
            return newCustomer;
        }

        public async Task UpdateCustomer(CustomerAddEditModal customer)
        {
            var existing = await _dbService.GetCustomerById(customer.CustomerId);
            if (existing != null)
            {
                _mapper.Map<CustomerAddEditModal,Customer>(customer,existing);
                await _dbService.UpdateCustomer(existing);
            }
        }

        public async Task UpdateCustomerImage(int customerid, string fileExtn)
        {
            await _dbService.UpdateCustomerImage(customerid, fileExtn);
        }

        public async Task DeleteCustomer(int id)
        {
            await _dbService.DeleteCustomer(id);
        }
    }
}
