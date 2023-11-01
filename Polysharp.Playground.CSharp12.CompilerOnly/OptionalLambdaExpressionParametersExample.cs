namespace Polysharp.Playground.CSharp12.CompilerOnly;

public class OptionalLambdaExpressionParametersExample
{
	public void Test()
	{
		var addWithDefault = (int addTo = 2) => addTo + 1;
		addWithDefault(); // 3
		addWithDefault(5); // 6

		var counter = (params int[] xs) => xs.Length;
		counter(); // 0
		counter(1, 2, 3); // 3
	}
}