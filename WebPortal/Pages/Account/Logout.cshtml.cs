using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPortal.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        
        public LogoutModel()
        {
           
        }

        public async Task<IActionResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync();
            return Page(); // or wherever you want to go after logout
        }
    }
}
