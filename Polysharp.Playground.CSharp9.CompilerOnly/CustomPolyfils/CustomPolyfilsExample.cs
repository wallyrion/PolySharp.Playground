namespace Polysharp.Playground.CSharp9.CompilerOnly.CustomPolyfils
{
	public class CustomPolyfilsExample
	{
		public string Test()
		{

			var test = new InitOnlySettersExample()
			{
				FirstName = "qwerty"
			};


			return test.FirstName;
		}
	}
}