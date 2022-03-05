using System;
using System.ComponentModel.DataAnnotations;

namespace SensoStatWeb.WebApplication.ViewModels
{
	public class CreateSurveyViewModel
	{
        [Required(ErrorMessage = "Entrez le nom d'une séance"),
         MinLength(2, ErrorMessage = "Le nom de la séance doit contenir au moins 2 caractères"),
         MaxLength(15, ErrorMessage = "Le nom de la séance doit contenir un maximum de 15 caractères")]
        public string SurveyName { get; set; }

        public string? ErrorMessage { get; set; }
    }
}