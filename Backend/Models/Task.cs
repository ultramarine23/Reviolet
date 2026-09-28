using System;

namespace Reviolet.Models;

public class Task : IReadTask
{
	public Guid Uuid { get; }
	public string Description { get; }
	
	public Task()
	{
		Uuid = Guid.CreateVersion7();
		Description = "abcd";
	}

	public Task(Guid uuid)
	{
		Uuid = uuid;
		Description = "abcd";
	}
}