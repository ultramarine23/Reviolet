using System;

namespace Reviolet.Models;

public class Task : IReadTask
{
	public Guid Uuid { get; }
	
	public Task()
	{
		Uuid = Guid.CreateVersion7();
	}

	public Task(Guid uuid)
	{
		Uuid = uuid;
	}
}