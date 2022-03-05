using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SensoStatWeb.Models.Entities
{
    [Table("SurveyState")]
    public class SurveyState
    {
        [Key]
        public int Id { get; set; }
        public string? Libelle { get; set; }

        [JsonIgnore]
        public List<Survey>? Surveys { get; set; }
    }
}
