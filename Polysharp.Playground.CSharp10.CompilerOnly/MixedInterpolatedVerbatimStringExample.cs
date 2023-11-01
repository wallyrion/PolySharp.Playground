namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class MixedInterpolatedVerbatimStringExample
{
	public void Test()
	{
		var bookName = "The Lord of the Rings";
		var author = "J.R.R. Tolkien";
		var publicationYear = 1954;

		var str = $@"The book {bookName} 
              by {author}
              was first published in {publicationYear}.";

		Console.WriteLine(str);
		
		// In this example, $ is used to interpolate variables in the string, and @ is used so the string can span multiple lines.
	}
}