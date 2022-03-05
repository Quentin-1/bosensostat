using System;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Repository.Interfaces
{
	public interface IQuestionRepository
	{
		List<Question> GetAllQuestions();

		Task<Question>? CreateQuestion(Question question);

		Task<bool>? DeleteQuestion(int id);
	}
}