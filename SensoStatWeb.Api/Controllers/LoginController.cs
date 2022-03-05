using Microsoft.AspNetCore.Mvc;
using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.Repository.Interfaces;

namespace SensoStatWeb.Api.Controllers;
[ApiController]
[Route("[controller]")]

public class LoginController : Controller
{
    public IAdministratorRepository _administrationRepository;

    public LoginController(IAdministratorRepository administratorRepository)
    {
        _administrationRepository = administratorRepository;
    }

    // GET: LoginController
    [HttpGet]
    public IActionResult Get([FromQuery] string login, [FromQuery] string password)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) return BadRequest();
        var admin = _administrationRepository.Login(login,password);
        if (admin == null) return NotFound();
        return Ok(new AdministratorTokenDTODown
        {
            Administrator = admin.Administrator,
            Token = admin.Token,
        });
    }
}
