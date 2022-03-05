using System;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Repository.Interfaces
{
	public interface ISurveyStateRepository
	{
		public Task<SurveyState> GetSurveyState(int id);
	}
}

