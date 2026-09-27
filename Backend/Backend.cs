namespace Reviolet;

public class Backend
{
	public AppState AppState { get; }
	public StateQuery StateQuery { get; }

	public TaskService TaskService { get; }
	// ... add more services later
	
	public Backend()
	{
		AppState = new();
		StateQuery = new(AppState);

		TaskService = new(AppState);
	}
}