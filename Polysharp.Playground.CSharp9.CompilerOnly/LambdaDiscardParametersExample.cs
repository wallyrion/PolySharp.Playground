using System;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class LambdaDiscardParametersExample
	{
		public void TestMethod()
		{
			Action<string, int> myAction = (_, _) => Console.WriteLine("Discarding both parameters");
			myAction("test", 1);
		}
	}
}