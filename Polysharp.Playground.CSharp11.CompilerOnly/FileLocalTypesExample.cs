// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class FileLocalTypesExample
{
	public void Test()
	{
		var example = new SomeFileLocalType();

		example.GetExample();
	}
	
}

file record SomeFileLocalType
{
	public string FirstName { get; set; } = null!;

	public SomeFileLocalType GetExample()
	{
		return new SomeFileLocalType
		{
			FirstName = "John"
		};
	}
}