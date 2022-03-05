using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SensoStatWeb.Models.Entities
{
    [Table("Answer")]
    public class Answer
    {
        public string? UserId { get; set; }
        public User? User { get; set; }
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public string? UserAnswer { get; set; }
    }
}
