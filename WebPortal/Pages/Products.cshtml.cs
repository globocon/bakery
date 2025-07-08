using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebPortal.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly IProductsDataProvider _productsDataProvider;

        public ProductsModel(IProductsDataProvider productsDataProvider)
        {
            _productsDataProvider = productsDataProvider;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGet()
        {
            Products = await _productsDataProvider.GetProducts();
        }
    }
}