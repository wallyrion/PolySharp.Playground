namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class FileLocalTypesExample
{
	public void Test()
	{
		var example = new SomeFileLocalType();
	}
	
}

file record SomeFileLocalType
{
	public string FirstName { get; set; }
	
	public SomeFileLocalType GetExample()
	{
		return new SomeFileLocalType
		{
			FirstName = "John"
		};
	}
}