using System;
using SensoStatWeb.Models.Entities;

namespace SensoStatWeb.Repository.Interfaces
{
	public interface IUserRepository
	{
		public Task<User> GetUser(string id);

		public Task<User> CreateUser(User user);

		public Task<List<User>> GetUsers();
	}
}

