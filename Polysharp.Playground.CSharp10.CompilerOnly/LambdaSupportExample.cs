namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class LambdaSupportExample
{
	Func<int, int> Increment = [return: MyCustom](x) => x + 1;

	// Lambda expressions in more locations
	public void LambdaAsMethodParameter()
	{
		MethodThatTakesAction(() => Console.WriteLine("Lambda as method parameter"));
	}

	public void Test()
	{
		var actionVariable = () => Console.WriteLine("Inferred Action Delegate Type");
	}
	
	public void MethodThatTakesAction(Action action) => action();

	[AttributeUsage(AttributeTargets.All)]
	public class MyCustomAttribute : Attribute
	{
		public MyCustomAttribute() { }
	}
}