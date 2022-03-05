using System;
namespace SensoStatWeb.Models.DTOs.Down
{
    public class PresentationPlanDTODown
    {
        public string UserCode { get; set; }
        public IEnumerable<string> Products { get; set; }
    }
}