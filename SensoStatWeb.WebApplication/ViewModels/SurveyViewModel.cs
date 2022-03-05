using System;
using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.Models.Entities.Interfaces;
using SensoStatWeb.WebApplication.Wrappers;

namespace SensoStatWeb.WebApplication.ViewModels
{
    public class SurveyViewModel
    {
        public SurveyCreationDTODown SurveyCreationDTODown { get; set; }
        public Survey Survey { get; set; }
        public IEnumerable<QuestionInstructionWrapper> QuestionsInstructions { get; set; }
    }
}

