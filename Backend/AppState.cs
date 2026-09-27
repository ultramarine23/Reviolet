using System.Collections.Generic;
using System.Collections.ObjectModel;
using Reviolet.Models;

namespace Reviolet;

public class AppState
{
	public List<Task> Tasks { get; }
	
	public AppState()
	{
		Tasks = new();
	}
}