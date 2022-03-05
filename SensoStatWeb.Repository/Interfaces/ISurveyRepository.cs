using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Repository.Interfaces
{
    public interface ISurveyRepository
    {
        List<Survey> GetAllSurveys();

        public Survey GetSurvey(int id);

        public Survey GetSurveyByUserId(int userId);

        Task<Survey> CreateSurvey(Survey survey);

        Task<Survey> UpdateSurvey(Survey survey);

        Task<bool> DeleteSurvey(int id);
    }
}
