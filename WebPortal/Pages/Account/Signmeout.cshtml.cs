using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Identity.Web;
using System;
using static System.Net.WebRequestMethods;
using BMS.Data.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebPortal.Pages.Account
{
    [Authorize]
    public class SignmeoutModel : PageModel
    {
        private IConfiguration configuration;


        public SignmeoutModel(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public async Task<IActionResult> OnGet()
        {

            //var authresult = await HttpContext.AuthenticateAsync();
            //var userClaims = authresult.Principal.Claims;
            //var metadata = authresult.Properties.Items;

            //var tkn = metadata.Where(x => x.Key == ".Token.id_token").FirstOrDefault().Value;

            //string? redirectstartbaseUrl = HttpRequestExtensions.GetBaseUrl;
            //string redirectendUrl = configuration["AppLogoutEndPointCallback:redirectendUrl"]; 
            //string logouturl = "";
            //string baseurl = configuration["AppLogoutEndPointCallback:baseurl"]; 
            //string redirecturl = string.Concat(redirectstartbaseUrl, redirectendUrl);
            //string encodedurl = Uri.EscapeDataString(redirecturl);
            //logouturl = string.Concat(baseurl, "?id_token_hint=", tkn, "&post_logout_redirect_uri=", encodedurl);


            //await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            //HttpContext.Session.Clear();
            //return Redirect(logouturl);

            return Redirect("/");

        }
    }
}
