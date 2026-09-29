using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reviolet.Utility;

public class ArrayPrint
{
	public static void PrintCollection<T>(ICollection<T> coll)
	{
		PrintCollection<T>(coll, "Printing collection");
	}

	public static void PrintCollection<T>(ICollection<T> coll, string name)
	{
		var total = coll.Count;

		Console.Write($"{name}: [ ");
		foreach (var elem in coll)
		{
			total -= 1;
			Console.Write($"{elem}");

			if (total > 0)
			{
				Console.Write(", ");
			}
		}
		Console.Write(" ]\n");
	}


	public static void PrintEnumerable<T>(IEnumerable<T> coll)
	{
		PrintEnumerable(coll, "Printing collection");
	}


	public static void PrintEnumerable<T>(IEnumerable<T> enumerable, string name)
	{
		var total = enumerable.Count();

		Console.Write($"{name}: [ ");
		foreach (var elem in enumerable)
		{
			total -= 1;
			Console.Write($"{elem}");

			if (total > 0)
			{
				Console.Write(", ");
			}
		}
		Console.Write(" ]\n");
	}
}