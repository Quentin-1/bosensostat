using System;
namespace SensoStatWeb.Models.Entities.Interfaces
{
    public interface IQuestionInstruction
    {
        int Id { get; set; }
        string Libelle { get; set; }
        int Position { get; set; }
    }
}