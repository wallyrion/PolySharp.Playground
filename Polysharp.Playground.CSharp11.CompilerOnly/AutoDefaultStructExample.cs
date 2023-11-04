namespace Polysharp.Playground.CSharp11.CompilerOnly;

public struct AutoDefaultStructExample
{
	public int X { get; set; }
	public int Y { get; set; }
	
	public int Z { get; set; }

	public AutoDefaultStructExample()
	{
		X = 12;
		Y = 13;
	}
}