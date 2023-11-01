namespace Polysharp.Playground.CSharp12.CompilerOnly;

public class InlineArraysExample
{
	public Buffer Test()
	{
		var buffer = new Buffer();
		for (int i = 0; i < 10; i++)
		{
			buffer[i] = (char)('a' + i);
		}

		return buffer;
	}
	
	[System.Runtime.CompilerServices.InlineArray(10)]
	public struct Buffer
	{
		private char _element0;
	}
}