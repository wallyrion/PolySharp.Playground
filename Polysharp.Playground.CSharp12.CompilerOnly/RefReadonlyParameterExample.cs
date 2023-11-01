namespace Polysharp.Playground.CSharp12.CompilerOnly;

public class RefReadonlyParameterExample
{
	public void Test(int someValue, ref readonly SomeReadonlyStruct someRefReadonlyValue)
	{
		
	}
	
	public readonly ref struct SomeReadonlyStruct
	{
		
	}
}