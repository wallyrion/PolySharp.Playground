using System;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	class StaticLocalFunctionExample
	{
		public int Test()
		{
			var result = AddNumbers(5, 10);
			Console.WriteLine(result);
			return result;

			static int AddNumbers(int x, int y)
			{
				if (x < 0 || y < 0)
				{
					throw new ArgumentException("Input values must be positive.");
				}

				return x + y;
			}
		}
	}
}