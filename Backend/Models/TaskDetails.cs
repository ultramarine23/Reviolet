using System;

namespace Reviolet.Models;

public class TaskDetails
{
	public bool IsImportant		  { get; }
	public string Description 	  { get; }
	public DateTime DateDue 	  { get; }
	public DateTime DateCreated   { get; }
	public TimeSpan EstimatedTime { get; }


	public TaskDetails(
		bool isImportant,
		string description,
		DateTime dateDue,
		DateTime dateCreated,
		TimeSpan estimatedTime
	)
	{
		IsImportant = isImportant;
		Description = description;
		DateDue = dateDue;
		DateCreated = dateCreated;
		EstimatedTime = estimatedTime;
	}

	
}