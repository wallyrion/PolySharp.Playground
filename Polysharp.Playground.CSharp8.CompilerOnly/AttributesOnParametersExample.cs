using System;
using System.Runtime.InteropServices;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class AttributesOnParametersExample
	{
		public void MyFunction([Optional] string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				Console.WriteLine("No name provided.");
			}
			else
			{
				Console.WriteLine($"Hello, {name}!");
			}
		}
	}
}