using System.Collections.Generic;
using System.Threading.Tasks;

namespace Polysharp.Playground.CSharp8.RequireRuntime
{
	public class AsyncStreamExample
	{
		public async IAsyncEnumerable<int> GenerateSequence()
		{
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(100); // Simulate a delay
				yield return i;
			}
		}

		public async Task<List<int>> ConsumeEnumerable()
		{
			var list = new List<int>();
			await foreach(var number in GenerateSequence())
			{
				list.Add(number);
			}

			return list;
		}
	}
}