﻿using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace WebPortal.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IUserAuthenticationService _userAuthentication;

        public LoginModel(IUserAuthenticationService userAuthentication)
        {
            _userAuthentication = userAuthentication;
        }
        [BindProperty]
        public USR_Login LoginUser { get; set; }

        public void OnGet()
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                // In development mode, pre-fill the login credentials for testing purposes
                if (LoginUser == null)
                {
                    LoginUser = new USR_Login() { LoginId = "Admin", Password = "admin@123" };
                }
            }
            else {
                LoginUser = new USR_Login(); 
            }                
        }

       

        public IActionResult OnPost(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl))
                returnUrl = Url.Page("/Orders");

            var isValidLogin = _userAuthentication.TryGetLoginUser(LoginUser, out USR_Users user);

            if (!isValidLogin)
                ModelState.AddModelError("LoginId", "Incorrect User Id or Password");
            //else if (!user.IsAdmin)
            //    ModelState.AddModelError("Username", "Not authorized to access this page");
            else
            {
                SignInUser(user);
                return Redirect(Url.Page("/Orders"));
            }
            return Page();
        }

        private void SignInUser(USR_Users user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.IsAdmin ? "Administrator" : "User"),
                new Claim("ImgFileExtn", user.ImgFileExtn ?? string.Empty) // Added custom claim
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
                RedirectUri = Url.Page("/Account/Login")
            };

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), authProperties);
        }
    }
}
