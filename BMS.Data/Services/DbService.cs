using BMS.Data.Entity;
using BMS.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data.Services
{
    public interface IDbService
    {
        #region "Customers"
        Task<List<Customer>> GetCustomers();
        Task<Customer?> GetCustomerById(int Id);
        Task AddCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task UpdateCustomerImage(int customerid, string fileExtn);
        Task DeleteCustomer(int id);
        #endregion "Customers"

        #region "Products"
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int id);
        Task<Product?> GetProductByName(string pname);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
        #endregion "Products"

        #region "Teams"
        Task<List<PreparationTeam>> GetTeams();
        Task<PreparationTeam?> GetTeamById(int id);
        Task AddTeam(PreparationTeam preparationTeam);
        Task UpdateTeam(PreparationTeam preparationTeam);
        Task DeleteTeam(int id);
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
        Task<RawMaterial?> GetRawMaterialById(int id);
        Task<RawMaterial?> GetRawMaterialByName(string pname);
        Task AddRawMaterial(RawMaterial rm);
        Task UpdateRawMaterial(RawMaterial rm);
        Task UpdateRawMaterialStockBulk(List<RawMaterial> rm);
        Task DeleteRawMaterial(int id);
        #endregion "RawMaterials"

        #region "Product RawMaterial MapType"
        Task<List<ProductRawMaterialMapType>> GetProductRawMaterialMapTypes();
        Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeByName(string pname);
        Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeById(int id);
        Task AddProductRawMaterialMapType(ProductRawMaterialMapType prmmt);
        Task UpdateProductRawMaterialMapType(ProductRawMaterialMapType prmmt);
        Task DeleteProductRawMaterialMapType(int id);
        #endregion "Product RawMaterial MapType"

        #region "ProductRawMaterials"
        Task<List<ProductRawMaterial>> GetAllProductRawMaterialsMappingList();
        Task<List<ProductRawMaterial>> GetProductRawMaterialsMappingByProductId(int ProductId);
        Task<ProductRawMaterial> GetProductRawMaterialMappingById(int Id);
        Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialId(int ProductId, int RawMaterialId);
        Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialIdAndMapType(int ProductId, int RawMaterialId, string MapType);
        Task AddProductRawMaterialMapping(ProductRawMaterial ingredient);
        Task UpdateProductRawMaterialMapping(ProductRawMaterial ingredient);
        Task BulkUpdateProductRawMaterialMappingSaveChanges();
        Task DeleteProductRawMaterialMapping(int Id);
        Task<List<ProductRawMaterialMapType>> GetProductRawMaterialMapType();
        #endregion "ProductRawMaterials"

        #region "Invoices"
        Task<List<Invoice>> GetInvoicesAsync();
        Task<Invoice?> GetInvoiceByIdAsync(int id);
        Task<Invoice?> GetInvoiceByInvoiceNumberAsync(string invoiceNumber);
        Task<Invoice?> GetInvoiceByCustomerIdAndDateAsync(int customerId, DateTime date);
        Task AddInvoiceAsync(Invoice invoice);
        Task AddInvoiceListAsync(List<Invoice> invoices);
        Task UpdateInvoiceAsync();
        Task DeleteInvoiceAsync(int id);      
        
        #endregion "Invoices"

        #region "Orders"
        Task<Order> CreateNewOrderAsync(Order NewOrder);
        Task<Order>? GetOrderById(int OrderId);
        Task<List<Order>?> GetOrderByCustomerIdAndOrderDate(int CustomerId, DateTime OrderDate);
        Task<List<Order>?> GetAllOrdersUnderCustomerId(int CustomerId);
        Task<List<Order>?> GetAllOrdersByOrderDate(DateTime OrderDate);
        Task ConfirmOrders(List<OrderConfirmData> ocd);
        Task<List<OrderConfirmData>> GetOrderConfirmDataByDateAndStatus(DateTime orderDate);
        #endregion "Orders"

        #region "Uom"
        Task<List<UomMaster>> GetUoms();
        Task<UomMaster?> GetUomById(int id);
        Task<UomMaster?> GetUomByName(string pname);
        Task AddUom(UomMaster uom);
        Task UpdateUom(UomMaster uom);
        Task DeleteUom(int id);
        #endregion "Uom"
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
        public async Task<Customer?> GetCustomerById(int Id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => !c.IsDeleted && c.CustomerId == Id);
        }

        public async Task AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await _context.SaveChangesAsync();
        }    

        public async Task UpdateCustomerImage(int customerid, string fileExtn)
        {
            var _customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == customerid && !c.IsDeleted);
            if (_customer != null)
            {
                _customer.ImgFileExtn = fileExtn;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomer(int id)
        {
            var _customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == id && !c.IsDeleted);
            if (_customer != null)
            {
                _customer.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
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
        public async Task<Product?> GetProductById(int id)
        {
            return await _context.Products
                .Include(c => c.Category)
                .Include(s => s.SubCategory)
                .FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }
        public async Task<Product?> GetProductByName(string pname)
        {
            return await _context.Products
                .Include(c => c.Category)
                .Include(s => s.SubCategory)
                .FirstOrDefaultAsync(c => c.Name.Trim().ToLower() == pname.Trim().ToLower() && !c.IsDeleted);
        }
        public async Task AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProduct(Product product)
        {
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (product != null)
            {
                product.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
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
        public async Task<RawMaterial?> GetRawMaterialById(int id)
        {
            return await _context.RawMaterials
                .FirstOrDefaultAsync(c => c.RawMaterialId == id && !c.IsDeleted);
        }
        public async Task<RawMaterial?> GetRawMaterialByName(string pname)
        {
            return await _context.RawMaterials.FirstOrDefaultAsync(c => c.Name.Trim().ToLower() == pname.Trim().ToLower() && !c.IsDeleted);
        }
        public async Task AddRawMaterial(RawMaterial rm)
        {
            _context.RawMaterials.Add(rm);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRawMaterial(RawMaterial rm)
        {
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRawMaterialStockBulk(List<RawMaterial> rm)
        {
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRawMaterial(int id)
        {
            var rm = await _context.RawMaterials.FirstOrDefaultAsync(c => c.RawMaterialId == id && !c.IsDeleted);
            if (rm != null)
            {
                rm.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
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

        public async Task<PreparationTeam?> GetTeamById(int id)
        {
            return await _context.PreparationTeams
                .FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
        }

        public async Task AddTeam(PreparationTeam preparationTeam)
        {
            _context.PreparationTeams.Add(preparationTeam);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTeam(PreparationTeam preparationTeam)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTeam(int id)
        {
            var category = await _context.PreparationTeams.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (category != null)
            {
                category.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
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

        public async Task<List<OrderConfirmData>> GetOrderConfirmDataByDateAndStatus(DateTime orderDate)
        {
            // Assuming you have a DbSet<OrderConfirmData> in your context
            return await _context.OrderConfirmData
                .Where(o => o.OrderDate.Date == orderDate.Date)
                .ToListAsync();
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

        public async Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialId(int ProductId, int RawMaterialId)
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(c => c.ProductId == ProductId && c.RawMaterialId == RawMaterialId);
        }

        public async Task<ProductRawMaterial?> GetProductRawMaterialMappingByProductIdAndRawMaterialIdAndMapType(int ProductId, int RawMaterialId, string MapType)
        {
            return await _context.ProductRawMaterials
                .Include(p => p.RawMaterial)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(c => c.ProductId == ProductId && c.RawMaterialId == RawMaterialId && c.MapType == MapType);
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

        public async Task BulkUpdateProductRawMaterialMappingSaveChanges()
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
        public async Task<List<ProductRawMaterialMapType>> GetProductRawMaterialMapType()
        {
            return await _context.ProductRawMaterialMapType.ToListAsync();
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

        #region "Invoices"
        
        public async Task AddInvoiceAsync(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            invoice.InvoiceNumber = $"INV-{invoice.InvoiceId:D6}-{DateTime.UtcNow.Year}";
            await _context.SaveChangesAsync();
            return;
        }
        public async Task AddInvoiceListAsync(List<Invoice> invoices)
        {
            _context.Invoices.AddRange(invoices);
            await _context.SaveChangesAsync();

            foreach (var invoice in invoices)
            {
                invoice.InvoiceNumber = $"INV-{invoice.InvoiceId:D6}-{DateTime.UtcNow.Year}";                
            }
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return await _context.Invoices.FirstOrDefaultAsync(i => i.InvoiceId == id);
        }
                        
        public async Task<Invoice?> GetInvoiceByCustomerIdAndDateAsync(int customerId, DateTime date)
        {
            return await _context.Invoices
                .Include(i => i.Customer)
                .Include(i => i.InvoiceItems).ThenInclude(ii => ii.Product)
                .FirstOrDefaultAsync(i => i.CustomerId == customerId && i.InvoiceDate.Date == date.Date);
        }

        public async Task<Invoice?> GetInvoiceByInvoiceNumberAsync(string invoiceNumber)
        {
            return await _context.Invoices.FirstOrDefaultAsync(i => i.InvoiceNumber == invoiceNumber);
        }

        public async Task UpdateInvoiceAsync()
        {
            //_context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices.FirstOrDefaultAsync(i => i.InvoiceId == id);
            if (invoice != null)
            {
                invoice.IsDeleted = true; // Soft delete 
                await _context.SaveChangesAsync();
            }
        }

        #endregion "Invoices"

        #region "Product RawMaterial MapType"
        public async Task<List<ProductRawMaterialMapType>> GetProductRawMaterialMapTypes()
        {
            return await _context.ProductRawMaterialMapType
                .OrderBy(p => p.MapTypeName)
                .ToListAsync();
        }

        public async Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeByName(string pname)
        {
            return await _context.ProductRawMaterialMapType.FirstOrDefaultAsync(c => c.MapTypeName.Trim().ToLower() == pname.Trim().ToLower());
        }

        public async Task<ProductRawMaterialMapType?> GetProductRawMaterialMapTypeById(int Id)
        {
            return await _context.ProductRawMaterialMapType.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task AddProductRawMaterialMapType(ProductRawMaterialMapType prmmt)
        {
            _context.ProductRawMaterialMapType.Add(prmmt);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProductRawMaterialMapType(ProductRawMaterialMapType prmmt)
        {
            await _context.SaveChangesAsync();
        }
        
        public async Task DeleteProductRawMaterialMapType(int id)
        {
            var rm = await _context.ProductRawMaterialMapType.FirstOrDefaultAsync(c => c.Id == id);
            if (rm != null)
            {
                var ex = _context.ProductRawMaterials.Count(p => p.MapType == rm.MapTypeName);
                if (ex > 0)
                {
                    throw new InvalidOperationException($"Cannot delete Map Type '{rm.MapTypeName}' as it is used in Product Raw Material mappings.");
                }

                _context.ProductRawMaterialMapType.Remove(rm);
                await _context.SaveChangesAsync();
            }
        }
        #endregion "Product RawMaterial MapType"

        #region "Uom"
        public async Task<List<UomMaster>> GetUoms()
        {
            return await _context.UomMaster.ToListAsync();
        }
        public async Task<UomMaster?> GetUomByName(string pname)
        {
            return await _context.UomMaster.FirstOrDefaultAsync(c => c.UOMName.Trim().ToLower() == pname.Trim().ToLower());
        }
        public async Task<UomMaster?> GetUomById(int id)
        {
            return await _context.UomMaster.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddUom(UomMaster uom)
        {
            _context.UomMaster.Add(uom);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUom(UomMaster uom)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUom(int id)
        {
            var rm = await _context.UomMaster.FirstOrDefaultAsync(c => c.Id == id);
            if (rm != null)
            {
                var exp = _context.Products.Count(p => p.UOM.ToLower() == rm.UOMName.ToLower());
                if (exp > 0)
                {
                    throw new InvalidOperationException($"Cannot delete Uom '{rm.UOMName}' as it is used in Product mappings.");
                }
                var exr = _context.RawMaterials.Count(p => p.Unit.ToLower() == rm.UOMName.ToLower());
                if (exr > 0)
                {
                    throw new InvalidOperationException($"Cannot delete Uom '{rm.UOMName}' as it is used in Ingridents mappings.");
                }

                _context.UomMaster.Remove(rm);
                await _context.SaveChangesAsync();
            }
        }
        #endregion "Uom"
    }
}
