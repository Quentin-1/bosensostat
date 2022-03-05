using System;
using Microsoft.AspNetCore.Mvc;
using SensoStatWeb.Business.Interfaces;
using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.WebApplication.Commons;
using SensoStatWeb.WebApplication.Services.Interfaces;
using SensoStatWeb.WebApplication.ViewModels;

namespace SensoStatWeb.WebApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAdministratorService _administratorService;

        public LoginController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public async Task<IActionResult> Authenticate(LoginViewModel loginViewModel)
        {
            // If the model state are not valid
            if (!ModelState.IsValid)
                return this.View("Index", loginViewModel); // redirect to Index page

            var resultLogin = await _administratorService.Login(loginViewModel.Username, loginViewModel.Password);

            // If the password or the username are false
            if (resultLogin == null)
            {
                loginViewModel.ErrorMessage = "Nom d'utilisateur ou mot de passe incorect";
                return this.View("Index", loginViewModel);
            }

            HttpContext.Response.Cookies.Append("Token", resultLogin.Token, new CookieOptions() { HttpOnly = true, SameSite = SameSiteMode.Strict });

            // When the password is correct
            return RedirectToAction("Index", "surveys");
        }
    }
}