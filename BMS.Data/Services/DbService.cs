
using BMS.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data.Services
{
    public interface IDbService
    {
        #region "Customers"
        Task<List<Customer>> GetCustomers();
        Task<Customer?> GetCustomersById(int Id);
        #endregion "Customers"

        #region "Products"
        Task<List<Product>> GetProducts();
        #endregion "Products"

        #region "Teams"
        Task<List<PreparationTeam>> GetTeams();
        #endregion "Teams"

        #region "Categories"
        Task<List<Category>> GetCategories();
        Task<Category?> GetCategoryById(int id);
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int id);
        #endregion "Categories"

        #region "SubCategories"
        Task<List<SubCategory>> GetSubCategories();
        Task<SubCategory?> GetSubCategoryById(int id);
        Task AddSubCategory(SubCategory category);
        Task UpdateSubCategory(SubCategory category);
        Task DeleteSubCategory(int id);
        #endregion "SubCategories"

        #region "RawMaterials"
        Task<List<RawMaterial>> GetRawMaterials();
        #endregion "RawMaterials"

        #region "ProductRawMaterials"
        Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingList();
        Task<List<ProductRawMaterial>> GetProductRawMaterialsMappingByProductId(int ProductId);
        Task<ProductRawMaterial> GetProductRawMaterialMappingById(int Id);
        Task<ProductRawMaterial> GetProductRawMaterialMappingByProductIdAndRawMaterialId(int ProductId, int RawMaterialId);
        Task AddProductRawMaterialMapping(ProductRawMaterial ingredient);
        Task UpdateProductRawMaterialMapping(ProductRawMaterial ingredient);
        Task DeleteProductRawMaterialMapping(int Id);
        #endregion "ProductRawMaterials"

        #region "Orders"
        Task<Order> CreateNewOrderAsync(Order NewOrder);
        Task<Order>? GetOrderById(int OrderId);
        Task<List<Order>?> GetOrderByCustomerIdAndOrderDate(int CustomerId, DateTime OrderDate);
        Task<List<Order>?> GetAllOrdersUnderCustomerId(int CustomerId);
        Task<List<Order>?> GetAllOrdersByOrderDate(DateTime OrderDate);
        Task ConfirmOrders(List<OrderConfirmData> ocd);
        #endregion "Orders"

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

        #region "Customers"

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.Name)
                .ToListAsync();
        }
        public async Task<Customer?> GetCustomersById(int Id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => !c.IsDeleted && c.CustomerId == Id);
        }

        #endregion "Customers"

        #region "Products"
        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products
                .Include(c => c.Category)
                .Include(s => s.SubCategory)
                .Where(p => !p.IsDeleted)
                .OrderBy(p => p.Name)
                .ToListAsync();
        }
        #endregion "Products"

        #region "RawMaterials"
        public async Task<List<RawMaterial>> GetRawMaterials()
        {
            return await _context.RawMaterials
                .Where(p => !p.IsDeleted)
                .OrderBy(p => p.Name)
                .ToListAsync();
        }
        #endregion "RawMaterials"

        #region "Teams"
        public async Task<List<PreparationTeam>> GetTeams()
        {
            return await _context.PreparationTeams
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.TeamName)
                .ToListAsync();
        }
        #endregion "Teams"

        #region "Orders"
        public async Task<Order> CreateNewOrderAsync(Order NewOrder)
        {
            _context.Orders.Add(NewOrder);
            await _context.SaveChangesAsync();
            NewOrder.OrderNumber = $"ORD-{NewOrder.OrderId:D6}-{DateTime.UtcNow.Year}";
            await _context.SaveChangesAsync();
            return NewOrder;
        }

        public async Task<Order?> GetOrderById(int OrderId)
        {
            return await _context.Orders.Include(o => o.Customer)
                  .Include(o => o.OrderItems)
                  .ThenInclude(oi => oi.Product)
                  .FirstOrDefaultAsync(o => !o.IsDeleted && o.OrderId == OrderId);
        }

        public async Task<List<Order>?> GetOrderByCustomerIdAndOrderDate(int CustomerId, DateTime OrderDate)
        {
            return await _context.Orders.Include(o => o.Customer)
                 .Include(o => o.OrderItems)
                 .ThenInclude(oi => oi.Product)
                 .Where(o => !o.IsDeleted && o.CustomerId == CustomerId && o.OrderDate == OrderDate)
                 .ToListAsync();
        }

        public async Task<List<Order>?> GetAllOrdersUnderCustomerId(int CustomerId)
        {
            return await _context.Orders.Include(o => o.Customer)
                 .Include(o => o.OrderItems)
                 .ThenInclude(oi => oi.Product)
                 .Where(o => !o.IsDeleted && o.CustomerId == CustomerId)
                 .ToListAsync();
        }

        public async Task<List<Order>?> GetAllOrdersByOrderDate(DateTime OrderDate)
        {
            return await _context.Orders.Include(o => o.Customer)
                 .Include(o => o.OrderItems)
                 .ThenInclude(oi => oi.Product)
                 .Where(o => !o.IsDeleted && o.OrderDate == OrderDate)
                 .ToListAsync();
        }

        public async Task ConfirmOrders(List<OrderConfirmData> ocd)
        {
            await _context.AddRangeAsync(ocd);
            await _context.SaveChangesAsync();
            return;
        }
        #endregion "Orders"

        #region "ProductRawMaterials"
        public async Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingList()
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .ToListAsync();
        }
        public async Task<List<ProductRawMaterial>> GetProductRawMaterialsMappingByProductId(int ProductId)
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .Where(c => c.ProductId == ProductId)
                .ToListAsync()
                ?? throw new KeyNotFoundException($"ProductRawMaterial with Product Id {ProductId} not found or is deleted.");
        }

        public async Task<ProductRawMaterial> GetProductRawMaterialMappingByProductIdAndRawMaterialId(int ProductId,int RawMaterialId)
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(c => c.ProductId == ProductId && c.RawMaterialId == RawMaterialId);
        }

        public async Task<ProductRawMaterial> GetProductRawMaterialMappingById(int Id)
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(c => c.Id == Id)
                ?? throw new KeyNotFoundException($"ProductRawMaterial with Id {Id} not found or is deleted.");

        }

        public async Task AddProductRawMaterialMapping(ProductRawMaterial ingredient)
        {
            _context.Add(ingredient);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task UpdateProductRawMaterialMapping(ProductRawMaterial ingredient)
        {
            await _context.SaveChangesAsync();
            return;
        }

        public async Task DeleteProductRawMaterialMapping(int Id)
        {
            var found = await _context.ProductRawMaterials.FirstOrDefaultAsync(p => p.Id == Id)
                ?? throw new KeyNotFoundException($"ProductRawMaterial with Id {Id} not found or is deleted.");

            if (found != null)
            {
                _context.Remove(found);
                await _context.SaveChangesAsync();
            }
            return;
        }

        #endregion "ProductRawMaterials"

        #region "Categories"
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories
                .Include(c => c.PreparationTeam)
                .Where(c => !c.IsDeleted)
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryById(int id)
        {
            return await _context.Categories
                .Include(c => c.PreparationTeam)
                .FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }

        public async Task AddCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (category != null)
            {
                category.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
        #endregion "Categories"

        #region "SubCategories"
        public async Task<List<SubCategory>> GetSubCategories()
        {
            return await _context.SubCategories
                .Where(sc => !sc.IsDeleted)
                .ToListAsync();
        }

        public async Task<SubCategory?> GetSubCategoryById(int id)
        {
            return await _context.SubCategories
               .Include(c => c.Category)
               .FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }

        public async Task AddSubCategory(SubCategory subcategory)
        {
            _context.SubCategories.Add(subcategory);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSubCategory(SubCategory category)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSubCategory(int id)
        {
            var subcategory = await _context.SubCategories.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (subcategory != null)
            {
                subcategory.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
        #endregion "SubCategories"

    }
}
