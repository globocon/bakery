
using BMS.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data.Services
{
    public interface IDbService
    {
        #region "Customers"
        Task<List<Customer>> GetCustomers();
        #endregion "Customers"

        #region "Products"
        Task<List<Product>> GetProducts();
        #endregion "Products"

        #region "Teams"
        Task<List<PreparationTeam>> GetTeams();
        #endregion "Teams"

    }
    public class DbService : IDbService
    {
        private readonly BMSDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DbService(BMSDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.Name)
                .ToListAsync();                
        }

        public async Task<List<Product>> GetProducts()
        {
            return  await _context.Products
                .Where(p => !p.IsDeleted)
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<List<PreparationTeam>> GetTeams()
        {
            return await _context.PreparationTeams
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.TeamName)
                .ToListAsync();
        }
    }
}
