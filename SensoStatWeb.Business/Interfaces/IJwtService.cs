using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Business.Interfaces
{
    public interface IJwtService
    {
        string generateJwtToken(Administrator administrator);
    }
}
