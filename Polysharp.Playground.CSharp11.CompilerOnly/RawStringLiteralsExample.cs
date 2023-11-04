namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class RawStringLiteralsExample
{
	public string GetJson(string firstName, string lastName)
	{
		return $$""""
		       {
		           "firstName": "{{firstName}}",
		           "lastName": "{{lastName}}"
		       }
		       """"; // This is a raw string literal
	}

	public record Person
	{
		public string FirstName { get; set; }
		
		public string LastName { get; set; }
	}
}