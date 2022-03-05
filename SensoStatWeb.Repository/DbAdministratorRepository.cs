using SensoStatWeb.Business;
using SensoStatWeb.Business.Interfaces;
using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;

namespace SensoStatWeb.Repository
{
    public class DbAdministratorRepository : IAdministratorRepository
    {
        private readonly SensoStatDbContext _context;
        private readonly IJwtService _jwtService;
        public DbAdministratorRepository(SensoStatDbContext context,IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService; 
        }

        public Administrator GetAdministrator(int id)
        {
            return _context.Administrators.FirstOrDefault(a => a.Id == id);
        }

        public AdministratorTokenDTODown Login(string username, string password)
        {
            var admin = _context.Administrators.FirstOrDefault(a => a.UserName == username && a.Password == password);
            var token = _jwtService.generateJwtToken(admin);
            var result = new AdministratorTokenDTODown() { Administrator = admin, Token = token };
            return result;
        }
    }
}