using System;
using Reviolet.Models;

namespace Reviolet;

public class TaskService
{
	private AppState _appState;
	
	public event Action? ModifiedTasklist;
	public event Action? ModifiedTasklistMember;

	public TaskService(AppState appState)
	{
		_appState = appState;
	}

	public void AddTask(Task newTask)
	{
		_appState.Tasks.Add(newTask);
		ModifiedTasklist?.Invoke();
	}

	public void RemoveTask(Task task)
	{
		_appState.Tasks.Remove(task);
		ModifiedTasklist?.Invoke();
	}
}