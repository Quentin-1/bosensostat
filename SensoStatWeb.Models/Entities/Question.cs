using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SensoStatWeb.Models.Entities.Interfaces;

namespace SensoStatWeb.Models.Entities
{
    [Table("Question")]
    public class Question : IQuestionInstruction
    {
        [Key]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Position { get; set; }
        public int SurveyId { get; set; }
        [ForeignKey("SurveyId")]
        [JsonIgnore]
        public Survey? Survey { get; set; }
        public List<Answer>? Answers { get; set; }
    }
}