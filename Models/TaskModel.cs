namespace TasksSystem.Models
{
	public class TaskModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public Enums.TaskStatus Status { get; set; }
	}
}