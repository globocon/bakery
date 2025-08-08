using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebPortal.Pages
{
    public class ProductIngredientsModel : PageModel
    {
        private readonly IProductsDataProvider _productsDataProvider;
        private readonly IRawMaterialsDataProvider _rawMaterialsDataProvider;
        private readonly IProductIngredientsDataProvider _productIngredientsDataProvider;

        public ProductIngredientsModel(
            IProductsDataProvider productsDataProvider,
            IRawMaterialsDataProvider rawMaterialsDataProvider,
            IProductIngredientsDataProvider productIngredientsDataProvider)
        {
            _productsDataProvider = productsDataProvider;
            _rawMaterialsDataProvider = rawMaterialsDataProvider;
            _productIngredientsDataProvider = productIngredientsDataProvider;
        }
                          
        public ProductRawMaterialAddModal ProductRawMaterialAddModal { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<RawMaterial> RawMaterials { get; set; } = new();
        public List<ProductRawMaterialMapType> ProductRawMaterial_MapType { get; set; } = new();

        public async Task OnGet(int? id, string? notify)
        {            
            Products = await _productsDataProvider.GetProducts();
            RawMaterials = await _rawMaterialsDataProvider.GetRawMaterials();
            ProductRawMaterial_MapType = await _productIngredientsDataProvider.GetAllProductRawMaterialMapTypeListAsync();                        
        }

        public async Task<IActionResult> OnGetShowAllProductIngredientsMappingAsync()
        {
            var result = await _productIngredientsDataProvider.GetAllProductRawMaterialsMappingListAsync();
            //Code to avoid recrussive json result
            if (result != null)
            {
                result.ForEach(p =>
                {
                    p.Product.ProductRawMaterials = null;
                    p.RawMaterial.ProductRawMaterials = null;
                });
            }
            return new JsonResult(result);
        }

        public async Task<JsonResult> OnPostUpdateProductIngredientMappingAsync(ProductRawMaterialAddModal productIngredientAddModal)
        {
            var status = true;
            var msg = "Product ingredient mapping updated successfully.";

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

                await _productIngredientsDataProvider.UpdateProductRawMaterialMappingAsync(productIngredientAddModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }

        public async Task<JsonResult> OnPostSaveProductIngredientMappingAsync(ProductRawMaterialAddModal productIngredientAddModal)
        {
            var status = true;
            var msg = "Product ingredient mapping added successfully.";

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

                await _productIngredientsDataProvider.AddProductRawMaterialMappingAsync(productIngredientAddModal);

            }
            catch (Exception ex)
            {
                status = false;
                msg = $"Error {ex.Message}";
            }

            return new JsonResult(new { status, message = msg });
        }
        public async Task<JsonResult> OnPostDeleteProductIngredientMappingAsync(int id)
        {
            var status = true;
            var msg = "Product ingredient mapping deleted successfully.";

            try
            {
                await _productIngredientsDataProvider.DeleteProductRawMaterialMappingAsync(id);
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