using System;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.WebApplication.ViewModels
{
    public class SurveysViewModel
    {
        public IEnumerable<Survey>? Surveys { get; set; }
    }
}

