using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SensoStatWeb.Models.Entities
{
    [Table("Administrator")]
    public class Administrator
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [JsonIgnore]
        public List<Survey>? Surveys { get; set;}
    }
}
