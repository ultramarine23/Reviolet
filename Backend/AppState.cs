using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Reviolet.Models;

namespace Reviolet;

public class AppState
{
	public HashSet<Task> Tasks => BacklogTasks.Union(InProgressTasks).Union(CompletedTasks).ToHashSet();

	public HashSet<Task> BacklogTasks = [];
	public HashSet<Task> InProgressTasks = [];
	public HashSet<Task> CompletedTasks = [];
	
	public AppState()
	{
		
	}
}