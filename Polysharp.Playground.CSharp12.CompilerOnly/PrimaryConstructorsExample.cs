namespace Polysharp.Playground.CSharp12.CompilerOnly;

public class PrimaryConstructorsExample(string firstName, string lastName)
{
	public string GetFullName()
	{
		return firstName + " " + lastName;
	}
}
