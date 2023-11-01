namespace Polysharp.Playground.CSharp12.CompilerOnly;

using Point = (int x, int y);

public class AliasAnyTypeExample
{
	public int Test(Point point)
	{
		return point.x + point.y; 
	}
}