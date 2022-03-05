using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Repository.Interfaces
{
    public interface IAdministratorRepository
    {
        public AdministratorTokenDTODown Login(string username, string password);

        public Administrator GetAdministrator(int id);
    }
}
