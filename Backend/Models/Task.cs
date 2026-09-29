using System;

namespace Reviolet.Models;

public class Task : IReadTask
{
	public Guid Uuid { get; }
	public TaskDetails Details { get; set; }
	
	public Task(TaskDetails details)
	{
		Uuid = Guid.CreateVersion7();
		Details = details;
	}

	public Task(Guid uuid, TaskDetails details)
	{
		Uuid = uuid;
		Details = details;
	}
}