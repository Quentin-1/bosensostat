using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoStatWeb.Business.Helpers
{
    public class ApiSettings
    {
        /// <summary>
        /// Secret utilisé pour vérifier le jeton JWT.
        /// </summary>
        public string? JwtSecret { get; set; }

        /// <summary>
        /// Emetteur du jeton (ici l'URL de l'API). (Exemple: https://domain.tld/)
        /// </summary>
        public string? JwtIssuer { get; set; }

        /// <summary>
        /// Cible du jeton JWT (quel service doit accepter ce jeton). (Exemple: https://domain.tld/)
        /// </summary>
        public string? JwtAudience { get; set; }
    }
}
