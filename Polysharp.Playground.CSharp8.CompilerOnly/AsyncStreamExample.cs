using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	/// <summary>
	/// Required library: Microsoft.Bcl.AsyncInterfaces
	/// </summary>
	public class AsyncStreamExample
	{
		public async IAsyncEnumerable<int> GenerateSequence(int count = 20)
		{
			for (var i = 0; i < count; i++)
			{
				await Task.Delay(new Random().Next(10, 100)); // Simulate a delay
				yield return i;
			}
		}

		public async Task<List<int>> ConsumeEnumerable(IAsyncEnumerable<int> sequence)
		{
			var list = new List<int>();
			await foreach(var number in sequence)
			{
				list.Add(number);
			}

			return list;
		}
	}
}