namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class ExtendedNameofScopeExample
{
	[MyAttribute(nameof(parameter))] void M(int parameter) { }	
}



public class MyAttribute : Attribute
{
	public MyAttribute(string name)
	{
		
	}
}