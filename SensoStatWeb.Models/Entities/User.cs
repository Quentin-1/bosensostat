using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SensoStatWeb.Models.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public string? Id { get; set; }
        public int SurveyId { get; set; }
        [ForeignKey("SurveyId")]
        public Survey? Survey { get; set; }
        public string? Code { get; set; }
        public string? Link { get; set; }
        public List<Answer>? Answers { get; set; }
        public List<UserProduct>? UserProducts { get; set; }
    }
}
