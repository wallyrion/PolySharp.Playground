namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class TargetTypedConditionalExpressionsExample
	{
		public void Test()
		{
			var status = true;
			int? res = status ? 123123 : null; // this was an error before C# 9
		}
	}
}