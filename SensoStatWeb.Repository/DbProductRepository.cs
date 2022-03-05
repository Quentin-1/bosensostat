using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensoStatWeb.Repository
{
    public class DbProductRepository : IProductRepository
    {
        private readonly SensoStatDbContext _context;

        public DbProductRepository(SensoStatDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            _context.Products?.Add(product);
            _context.SaveChanges();
            return _context.Products.Where(p => p.Equals(product)).FirstOrDefault();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
