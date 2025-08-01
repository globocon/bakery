using AutoMapper;
using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebPortal.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly IProductsDataProvider _productsDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;

        public ProductsModel(IProductsDataProvider productsDataProvider, ICategoryDataProvider categoryDataProvider)
        {
            _productsDataProvider = productsDataProvider;
            _categoryDataProvider = categoryDataProvider;
        }

        public List<Product> Products { get; set; } = new();
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet()
        {
            Products = await _productsDataProvider.GetProducts();
            Categories = await _categoryDataProvider.GetCategories();
        }

        public async Task<IActionResult> OnGetShowAllProductsAsync()
        {
            var result = await _productsDataProvider.GetProducts();
            //Code to avoid recrussive json result
            if (result != null)
            {
                result.ForEach(p =>
                {
                    p.Category.Products = null;
                });
            }
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateProductAsync(ProductAddEditModal productAddEditModal)
        {
            var status = true;
            var msg = "Product Updated Successfully.";

            try
            {
                if (!ModelState.IsValid)
                {
                    //var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => string.Join(',', $"{x.Value.Errors.Select(y => y.ErrorMessage).ToString().Replace(".","")} for {x.Value.(x=> x. )}."));
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }

                await _productsDataProvider.UpdateProduct(productAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveProductAsync(ProductAddEditModal productAddEditModal)
        {
            var status = true;
            var msg = "Product Added Successfully.";

            try
            {
                if (!ModelState.IsValid)
                {
                    //var errors = ModelState.Where(x => x.Value.Errors.Count > 0).Select(x => string.Join(',', $"{x.Value.Errors.Select(y => y.ErrorMessage).ToString().Replace(".","")} for {x.Value.(x=> x. )}."));
                    var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => $"{string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage))} for {x.Key}")
                        .ToList();

                    return new JsonResult(new { status = false, message = errors });
                }

                await _productsDataProvider.AddProduct(productAddEditModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteProductAsync(int id)
        {
            var status = true;
            var msg = "Product Deleted Successfully.";

            try
            {
                await _productsDataProvider.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
    }
}