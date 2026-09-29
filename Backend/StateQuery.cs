using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using Reviolet.Models;

namespace Reviolet;

public class StateQuery
{
	private AppState _source;
	
	public StateQuery(AppState source)
	{
		_source = source;
	}


	// --> query methods {y}
	public IEnumerable<IReadTask> GetTasks()
	{
		CollectionPrinter.PrintEnumerable(_source.Tasks);
		var res = _source.Tasks.Cast<IReadTask>();
		CollectionPrinter.PrintEnumerable(res);
		return res;
	}
	
	// do the same for other queriable state members...
}