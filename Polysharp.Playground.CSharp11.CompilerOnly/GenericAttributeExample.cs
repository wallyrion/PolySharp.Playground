namespace Polysharp.Playground.CSharp11.CompilerOnly;

[Generic<string>("Somevalue")]
public class GenericAttributeExample
{
	
}


public class GenericAttribute<T> : Attribute
{
	public GenericAttribute(T value)
	{
		
	}
}