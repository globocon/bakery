using BMS.Data.Models;
using BMS.Data.Providers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebPortal.Pages
{
    public class RawMaterialsModel : PageModel
    {
        private readonly IRawMaterialsDataProvider _rawMaterialsDataProvider;

        public RawMaterialsModel(IRawMaterialsDataProvider rawMaterialsDataProvider)
        {
            _rawMaterialsDataProvider = rawMaterialsDataProvider;
        }

        public List<RawMaterial> RawMaterials { get; set; } = new();

        public async Task OnGet()
        {
            RawMaterials = await _rawMaterialsDataProvider.GetRawMaterials();
        }
    }
}