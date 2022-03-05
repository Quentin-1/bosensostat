using SensoStatWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoStatWeb.Repository.Interfaces
{
    public interface IUserProductRepository
    {
        Task<UserProduct> CreateUserProduct(UserProduct userProduct);
    }
}
