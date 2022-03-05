using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SensoStatWeb.Business.Helpers;
using SensoStatWeb.Business.Interfaces;
using SensoStatWeb.Models.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SensoStatWeb.Business
{
    public class JwtService : IJwtService
    {
        private readonly ApiSettings _apiSettings;

        public JwtService(IOptions<ApiSettings> apiSettings)
        {
            _apiSettings = apiSettings.Value;
        }

        public string generateJwtToken(Administrator administrator)
        {
            // génère un token valide pour 7 jours
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_apiSettings.JwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id", administrator.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.FamilyName,administrator.LastName),
                    // Cela va garantir que le token est unique
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Issuer = _apiSettings.JwtIssuer,
                Audience = _apiSettings.JwtAudience,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
