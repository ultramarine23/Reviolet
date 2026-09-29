using System;

namespace Reviolet.Models;

public class TaskDetails
{
	public bool IsImportant		  { get; set; }
	public string Description 	  { get; set; }
	public DateTime DateDue 	  { get; set; }
	public DateTime DateCreated   { get; set; }
	public TimeSpan EstimatedTime { get; set; }


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