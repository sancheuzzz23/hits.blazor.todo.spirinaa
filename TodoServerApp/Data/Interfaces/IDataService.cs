namespace TodoServerApp.Data.Interfaces
{
	public interface IDataservice
	{
		Task<IEnumerable<TaskItem>> GetTaskItemAsync();
	}
}
