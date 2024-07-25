using Microsoft.EntityFrameworkCore;
using TasksSystem.Data.Map;
using TasksSystem.Models;

namespace TasksSystem.Data
{
	public class TasksSystemDbContext(DbContextOptions<TasksSystemDbContext> options) : DbContext(options)
	{
		public DbSet<UserModel> User { get; set; }
		public DbSet<TaskModel> Task { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserMap());
			modelBuilder.ApplyConfiguration(new TaskMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}