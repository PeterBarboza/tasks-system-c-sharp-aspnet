using Microsoft.EntityFrameworkCore;
using TasksSystem.Data;
using TasksSystem.Models;
using TasksSystem.Repositories.Interfaces;

namespace TasksSystem.Repositories
{
	public class UserRepository(TasksSystemDbContext tasksSystemDbContext) : IUserRepository
	{
		private readonly TasksSystemDbContext _dbContext = tasksSystemDbContext;

		public async Task<List<UserModel>> GetAllUsers()
		{
			return await _dbContext.User.ToListAsync();
		}

		public async Task<UserModel?> GetUserById(int id)
		{
			return await _dbContext.User.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<UserModel> CreateUser(UserModel userData)
		{
			await _dbContext.User.AddAsync(userData);
			await _dbContext.SaveChangesAsync();

			return userData;
		}

		public async Task<UserModel> UpdateUser(UserModel userData, int id)
		{
			UserModel? user = await GetUserById(id);

			if (user == null)
			{
				throw new Exception($"User with Id: {id} not found");
			}

			user.Name = userData.Name;
			user.Email = userData.Email;

			_dbContext.User.Update(userData);
			await _dbContext.SaveChangesAsync();

			return user;
		}

		public async Task<bool> DeleteUser(int id)
		{
			UserModel? user = await GetUserById(id);

			if (user == null)
			{
				return false;
			}

			_dbContext.User.Remove(user);
			await _dbContext.SaveChangesAsync();

			return true;
		}
	}
}