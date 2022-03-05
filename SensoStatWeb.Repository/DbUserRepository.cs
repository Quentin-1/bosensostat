using System;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;

namespace SensoStatWeb.Repository
{
	public class DbUserRepository : IUserRepository
	{
        private readonly SensoStatDbContext _context;
        public DbUserRepository(SensoStatDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public async Task<User> CreateUser(User user)
        {
            _context.Users?.Add(user);
            _context.SaveChanges();
            return _context.Users.Where(u => u.Equals(user)).FirstOrDefault();
        }

        public async Task<List<User>> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}

