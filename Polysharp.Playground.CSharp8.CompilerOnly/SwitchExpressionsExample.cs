namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class SwitchExpressionsExample
	{
		public string GetCSharpVersion(string dotnet) =>
			dotnet switch
			{
				"8" => "c# 12",
				_ => "c# 0"
			};
	}
}