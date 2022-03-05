using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;

namespace SensoStatWeb.Repository
{
    public class DbUserProductRepository : IUserProductRepository
    {
        private readonly SensoStatDbContext _context;
        public DbUserProductRepository(SensoStatDbContext context)
        {
            _context = context;
        }
        public async Task<UserProduct> CreateUserProduct(UserProduct userProduct)
        {
            _context.UserProducts.Add(userProduct);
            _context.SaveChanges();
            return _context.UserProducts.FirstOrDefault(up => up.Equals(userProduct));
        }
    }
}
