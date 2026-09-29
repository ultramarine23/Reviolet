using System;

namespace Reviolet.Models;

public interface IReadTask
{
	public Guid Uuid { get; }
	public TaskDetails Details { get; }
}