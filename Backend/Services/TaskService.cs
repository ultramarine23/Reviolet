using System;
using System.Linq;
using Reviolet.Models;

namespace Reviolet;


public enum TaskStatus
{
	BACKLOG,
	IN_PROGRESS,
	COMPLETED
}


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
		AddTask(newTask, TaskStatus.BACKLOG);
	}

	public void AddTask(Task newTask, TaskStatus status)
	{
		switch (status)
		{
			case TaskStatus.BACKLOG:
				_appState.BacklogTasks.Add(newTask);
				break;
			case TaskStatus.IN_PROGRESS:
				_appState.InProgressTasks.Add(newTask);
				break;
			case TaskStatus.COMPLETED:
				_appState.CompletedTasks.Add(newTask);
				break;
		}
		
		ModifiedTasklist?.Invoke();
	}

	public void RemoveTask(Task task)
	{
		_appState.Tasks.Remove(task);
		ModifiedTasklist?.Invoke();
	}

	public void MarkTask(Task task, TaskStatus newStatus)
	{
		// attempt-remove it from all lists
		_appState.BacklogTasks.Remove(task);
		_appState.InProgressTasks.Remove(task);
		_appState.CompletedTasks.Remove(task);
		
		// re-add it to the intended list
		switch (newStatus)
		{
			case TaskStatus.BACKLOG:
				_appState.BacklogTasks.Add(task);
				break;
			
			case TaskStatus.IN_PROGRESS:
				_appState.InProgressTasks.Add(task);
				break;

			case TaskStatus.COMPLETED:
				_appState.CompletedTasks.Add(task);
				break;
		}

		ModifiedTasklist?.Invoke();
		ModifiedTasklistMember?.Invoke();
	}

	public void ToggleCompleted(Task task)
	{
		task.Details.IsImportant = !task.Details.IsImportant;
		ModifiedTasklistMember?.Invoke();
	}

	public void EditTaskDetails(Task task, TaskDetails newDetails)
	{
		task.Details = newDetails;
		ModifiedTasklistMember?.Invoke();
	}
}