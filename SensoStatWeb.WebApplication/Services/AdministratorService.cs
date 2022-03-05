using System;
using SensoStatWeb.Business.Interfaces;
using SensoStatWeb.Models.DTOs.Down;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.WebApplication.Commons;
using SensoStatWeb.WebApplication.Services.Interfaces;

namespace SensoStatWeb.WebApplication.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly IHttpService _httpService;


        public AdministratorService(IHttpService httpService)
        {
            this._httpService = httpService;

        }

        public async Task<AdministratorTokenDTODown> Login(string username, string password)
        {
            var url = $"{Constants.BaseUrlApi}login?login={username}&password={password}";
            var administrator = await _httpService.SendHttpRequest<AdministratorTokenDTODown>(url, HttpMethod.Get);
            return administrator;
        }
    }
}

