using TasksSystem.Models;

namespace TasksSystem.Repositories.Interfaces
{
	public interface IUserRepository
	{
		Task<List<UserModel>> GetAllUsers();
		Task<UserModel?> GetUserById(int id);
		Task<UserModel> CreateUser(UserModel userData);
		Task<UserModel> UpdateUser(UserModel userData, int id);
		Task<bool> DeleteUser(int id);
	}
}