using System;

namespace Reviolet.Models;

public class Task : IReadTask
{
	public Guid Uuid { get; }
	public TaskDetails Details { get; set; }
	
	public Task()
	{
		Uuid = Guid.CreateVersion7();
		Details = new TaskDetails(
			isImportant: false,
			description:"toong toong",
			dateDue: DateTime.Now,
			dateCreated: DateTime.Now,
			estimatedTime: TimeSpan.FromHours(5)
		);
	}

	public Task(Guid uuid)
	{
		Uuid = uuid;
		Details = new TaskDetails(
			isImportant: false,
			description:"toong toong",
			dateDue: DateTime.Now,
			dateCreated: DateTime.Now,
			estimatedTime: TimeSpan.FromHours(5)
		);
	}
}