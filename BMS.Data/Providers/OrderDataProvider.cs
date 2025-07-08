using BMS.Data.Models;
using BMS.Data.Services;
using AutoMapper;
using BMS.Data.Helpers;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface IOrderDataProvider
    {
        Task<List<Order>> GetOrders();
        Task<List<Product>> GetAllActiveProducts();
        Task<List<Customer>> GetAllActiveCustomers();
        Task<string> SaveOrderAsync(OrderNewEdit order);
        Task<List<Order>> GetOrdersByDateAsync(DateTime orderDate);
        Task ConfirmOrdersAsync(List<int> orderIds);

    }
    public class OrderDataProvider : IOrderDataProvider
    {

        private readonly IDbService _dbService;

        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly ISubCategoryDataProvider _subCategoryDataProvider;
        private readonly ICustomerDataProvider _customerDataProvider;
        private readonly IInvoiceDataProvider _invoiceDataProvider;
        private readonly IProductIngredientsDataProvider _productIngredientsDataProvider;
        private readonly IProductsDataProvider _productsDataProvider;
        private readonly IRawMaterialsDataProvider _rawMaterialsDataProvider;
        private readonly ITeamsDataProvider _teamsDataProvider;


        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderDataProvider(IDbService dbService, ICategoryDataProvider categoryDataProvider, ISubCategoryDataProvider subCategoryDataProvider, 
            ICustomerDataProvider customerDataProvider,
            IInvoiceDataProvider invoiceDataProvider, IProductIngredientsDataProvider productIngredientsDataProvider,
            IProductsDataProvider productsDataProvider, IRawMaterialsDataProvider rawMaterialsDataProvider,
            ITeamsDataProvider teamsDataProvider, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _categoryDataProvider = categoryDataProvider ?? throw new ArgumentNullException(nameof(categoryDataProvider));
            _subCategoryDataProvider = subCategoryDataProvider ?? throw new ArgumentNullException(nameof(subCategoryDataProvider));
            _customerDataProvider = customerDataProvider ?? throw new ArgumentNullException(nameof(customerDataProvider));
            _invoiceDataProvider = invoiceDataProvider ?? throw new ArgumentNullException(nameof(invoiceDataProvider));
            _productIngredientsDataProvider = productIngredientsDataProvider ?? throw new ArgumentNullException(nameof(productIngredientsDataProvider));
            _productsDataProvider = productsDataProvider ?? throw new ArgumentNullException(nameof(productsDataProvider));
            _rawMaterialsDataProvider = rawMaterialsDataProvider ?? throw new ArgumentNullException(nameof(rawMaterialsDataProvider));
            _teamsDataProvider = teamsDataProvider ?? throw new ArgumentNullException(nameof(teamsDataProvider));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
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

        public async Task<string> SaveOrderAsync(OrderNewEdit order)
        {
            var orderEntity = _mapper.Map<Order>(order);

            // Set CreatedById using the global static helper
            orderEntity.CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? "";
            orderEntity.CreatedOn = DateTime.UtcNow;
            var savedOrder = await _dbService.CreateNewOrderAsync(orderEntity);
            return savedOrder?.OrderNumber ?? "";
        }

        public async Task<List<Order>> GetOrdersByDateAsync(DateTime orderDate)
        {
            // Fetch all orders for the given date (not deleted)
            var orders = await _dbService.GetAllOrdersByOrderDate(orderDate);
            return orders ?? new List<Order>();
        }

        public async Task ConfirmOrdersAsync(List<int> orderIds)
        {
            List<OrderConfirmData> orderConfirmDataList = new List<OrderConfirmData>();
            var Products = await _productsDataProvider.GetProducts();
            var Customers = await _customerDataProvider.GetCustomers();
            var Categories = await _categoryDataProvider.GetCategories();
            var PrepTeams = await _teamsDataProvider.GetTeams();
            var SubCategories = await _subCategoryDataProvider.GetSubCategories();
            var RawMaterials = await _rawMaterialsDataProvider.GetRawMaterials();
            var ProductRawMaterials = await _productIngredientsDataProvider.GetAllProductRawMaterialsMappingListAsync();

            string CreatedById = UserContextHelper.GetCurrentUserId(_httpContextAccessor) ?? ""; ;
            DateTime CreatedOnTime = DateTime.UtcNow;

            // Confirm orders by updating their status
            foreach (var orderId in orderIds)
            {
                var order = await _dbService.GetOrderById(orderId);
                if (order != null && order.Status != "Confirmed")
                {
                    order.Status = "Confirmed";

                    //Insert data into Order Confirm Table
                    
                    int CustomerId;
                    string CustomerName;                    
                    int CategoryId;
                    string CategoryName;
                    int? SubCategoryId;
                    string? SubCategoryName;
                    int TeamId;
                    string TeamName;
                    int ProductId;
                    string ProductName;
                    decimal ProductMRP;
                    string? ImgFileExtn;
                    int ProductOrderQuantity;
                    DateTime? OrderDeliveryDateTime;
                                        

                    foreach (var item in order.OrderItems)
                    {
                        CustomerId = order.CustomerId;
                        CustomerName = Customers.FirstOrDefault(c => c.CustomerId == order.CustomerId)?.Name ?? "";
                        CategoryId = item.Product.CategoryId;
                        CategoryName = Categories.FirstOrDefault(c => c.Id == item.Product.CategoryId)?.Name ?? "";
                        SubCategoryId = item.Product.SubCategoryId;
                        SubCategoryName = SubCategories.FirstOrDefault(sc => sc.Id == item.Product.SubCategoryId)?.Name ?? CategoryName;
                        
                        var product = Products.FirstOrDefault(p => p.Id == item.ProductId);
                        ProductId = product?.Id ?? 0;
                        ProductName = product?.Name ?? "";
                        ProductMRP = product?.MRP ?? 0;
                        ImgFileExtn = product?.ImgFileExtn;
                        ProductOrderQuantity = item.Quantity;
                        TeamId = PrepTeams.FirstOrDefault(t => t.Id == (Categories.FirstOrDefault(c => c.Id == CategoryId)?.PreparationTeamId ?? 0))?.Id ?? 0;
                        TeamName = PrepTeams.FirstOrDefault(t => t.Id == TeamId)?.TeamName ?? "";
                        OrderDeliveryDateTime = item.DeliveryDateTime;
                                                
                        // Set Raw Materials
                        foreach (var prm in ProductRawMaterials.Where(prm => prm.ProductId == product?.Id))
                        {                            
                            var rawMaterial = RawMaterials.FirstOrDefault(rm => rm.RawMaterialId == prm.RawMaterialId);
                            if (rawMaterial != null)
                            {
                                OrderConfirmData orderConfirmData = new OrderConfirmData();
                                                                
                                orderConfirmData.CustomerId = CustomerId;
                                orderConfirmData.CustomerName = CustomerName;
                                orderConfirmData.OrderId = order.OrderId;
                                orderConfirmData.OrderNumber = order.OrderNumber;
                                orderConfirmData.OrderDate = order.OrderDate;
                                orderConfirmData.CategoryId = CategoryId;
                                orderConfirmData.CategoryName = CategoryName;
                                orderConfirmData.SubCategoryId = SubCategoryId;
                                orderConfirmData.SubCategoryName = SubCategoryName;
                                orderConfirmData.TeamId = TeamId;
                                orderConfirmData.TeamName = TeamName;
                                orderConfirmData.ProductId = ProductId;
                                orderConfirmData.ProductName = ProductName;
                                orderConfirmData.ProductMRP = ProductMRP;
                                orderConfirmData.ImgFileExtn = ImgFileExtn;
                                orderConfirmData.ProductOrderQuantity = ProductOrderQuantity;
                                orderConfirmData.OrderDeliveryDateTime = OrderDeliveryDateTime;
                                orderConfirmData.RawMaterialId = rawMaterial.RawMaterialId;
                                orderConfirmData.RawMaterialName = rawMaterial.Name;
                                orderConfirmData.RawMaterialStockQuantity = rawMaterial.StockQuantity;
                                orderConfirmData.RawMaterialRequiredQuantity = prm.QuantityRequired;
                                orderConfirmData.RawMaterialCP = rawMaterial.CP;
                                orderConfirmData.RawMaterialUnit = rawMaterial.Unit;
                                orderConfirmData.CreatedById = CreatedById;
                                orderConfirmData.CreatedOn = CreatedOnTime;
                                orderConfirmDataList.Add(orderConfirmData);
                            }
                        }
                    }                    
                }
            }
            // Save changes
            await _dbService.ConfirmOrders(orderConfirmDataList);
        }
    }
}
