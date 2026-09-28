namespace Reviolet;

/* {#fff}
{ CLASS DESCRIPTION }
	A lightweight bundle of all the dependencies needed by component views
	of the Tasklist scene. Practically a glorified struct.
*/


public class TasklistDependencies
{
	// --> add more dependencies here {r}
	public StateQuery StateQuery { get; }
	
	public TaskService TaskService { get; }

	
	public TasklistDependencies(
		StateQuery stateQuery,
		TaskService taskService
	)
	{
		StateQuery = stateQuery;
		TaskService = taskService;
	}
}