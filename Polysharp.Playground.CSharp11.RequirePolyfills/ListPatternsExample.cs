namespace Polysharp.Playground.CSharp11.RequireRuntime;

public class ListPatternsExample
{
	public string Test(List<int> list)
	{
		return list switch
		{
			[_, 1, 3, ..] => "1",
			[_, 3] => "2",
			_ => "0"
		};
	}
}