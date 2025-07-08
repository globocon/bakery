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

        [BindProperty]
        public List<ProductRawMaterial> ProductIngredients { get; set; } = new();

        [BindProperty]
        public ProductRawMaterial Ingredient { get; set; } = new();

        public List<Product> Products { get; set; } = new();
        public List<RawMaterial> RawMaterials { get; set; } = new();

        public async Task OnGet(int? id, string? notify)
        {
            ProductIngredients = await _productIngredientsDataProvider.GetAllProductRawMaterialsMappingListAsync();
            Products = await _productsDataProvider.GetProducts();
            RawMaterials = await _rawMaterialsDataProvider.GetRawMaterials();

            if (id.HasValue)
            {
                Ingredient = await _productIngredientsDataProvider.GetProductRawMaterialMappingByIdAsync(id.Value) ?? new ProductRawMaterial();
            }

            // Set notification message if needed
            if (!string.IsNullOrEmpty(notify))
            {
                switch (notify)
                {
                    case "added":
                        TempData["NotifyMsg"] = "Ingredient added successfully.";
                        TempData["NotifyType"] = "success";
                        break;
                    case "updated":
                        TempData["NotifyMsg"] = "Ingredient updated successfully.";
                        TempData["NotifyType"] = "success";
                        break;
                    case "deleted":
                        TempData["NotifyMsg"] = "Ingredient deleted successfully.";
                        TempData["NotifyType"] = "success";
                        break;
                }
            }
        }

        public async Task<IActionResult> OnPostAddOrEditAsync()
        {
            if (!ModelState.IsValid)
            {
                await OnGet(null, null);
                return Page();
            }

            bool Isadd = Ingredient.Id == 0;

            if (Ingredient.Id == 0)
            {
                try
                {
                    await _productIngredientsDataProvider.AddProductRawMaterialMappingAsync(Ingredient);
                    TempData["NotifyMsg"] = "Ingredient added successfully.";
                    TempData["NotifyType"] = "success";
                }
                catch (Exception ex)
                {
                    TempData["NotifyMsg"] = $"Error adding ingredient: {ex.Message}";
                    TempData["NotifyType"] = "error";
                    return Page();
                }
                
            }
            else
            {
                try
                {
                    await _productIngredientsDataProvider.UpdateProductRawMaterialMappingAsync(Ingredient);
                    TempData["NotifyMsg"] = "Ingredient updated successfully.";
                    TempData["NotifyType"] = "success";
                }
                catch (Exception ex)
                {
                    TempData["NotifyMsg"] = $"Error updating ingredient: {ex.Message}";
                    TempData["NotifyType"] = "error";
                    return Page();
                }

            }
            
            TempData["NotifyType"] = "success"; 
            return RedirectToPage(new { notify = Isadd ? "added" : "updated" });
        }

        public async Task<IActionResult> OnGetDeleteAsync(int id)
        {
            await _productIngredientsDataProvider.DeleteProductRawMaterialMappingAsync(id);
            TempData["NotifyMsg"] = "Ingredient deleted successfully.";
            TempData["NotifyType"] = "success";
            return RedirectToPage(new { notify = "deleted" });
        }
    }
}