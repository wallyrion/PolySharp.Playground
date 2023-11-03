using System.Collections.Generic;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class NullCoalescingAssignmentExample
	{
		public string Test(string? input)
		{
			input ??= "Default Name";

			return input;
		}
	}
}