namespace Polysharp.Playground.CSharp9.CompilerOnly.PointersFeatures
{
	public class FunctionPointerExample
	{
		unsafe class Example
		{
			delegate*<int, int, int> addPtr = &Add;

			static int Add(int x, int y)
			{
				return x + y;
			}
		}
	}
}