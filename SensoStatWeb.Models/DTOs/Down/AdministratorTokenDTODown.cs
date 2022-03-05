using SensoStatWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoStatWeb.Models.DTOs.Down
{
    public class AdministratorTokenDTODown
    {
        public Administrator? Administrator { get; set; }

        public string? Token { get; set; }
    }
}
