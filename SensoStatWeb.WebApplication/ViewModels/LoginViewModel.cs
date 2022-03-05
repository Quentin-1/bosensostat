using System;
using System.ComponentModel.DataAnnotations;

namespace SensoStatWeb.WebApplication.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Entrez un nom d'utilisateur"), MinLength(2, ErrorMessage = "Le nom d'utilisateur doit posséder au moins 2 caractères")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Entrez un mot de passe"), MinLength(4, ErrorMessage = "Le mot de passe doit posséder au moins 4 caractères")]
        public string Password { get; set; }

        public string? ErrorMessage { get; set; }
    }
}

