namespace Polysharp.Playground.CSharp8.RequirePolyfills
{
	public class IndicesAndRangesExample
	{
		public string GetSubString(string example, int startWith, int lastIndexFromTheEnd)
		{
			var a = example[startWith..^lastIndexFromTheEnd];

			return a;
		}
		
		public string GetBeforeIndexFromEnd(string example, int beforeIndex)
		{
			var a = example[..^beforeIndex];

			return a;
		}

		/*public string Splited(string str)
		{
			if (str.Split() is not [var first, var second])
			{
				throw new ArgumentException("Str is not in correct format");
			}

			return first + second;
		}*/
	}
}