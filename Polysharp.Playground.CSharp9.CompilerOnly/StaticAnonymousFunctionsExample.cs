using System;
using System.Collections.Generic;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class StaticAnonymousFunctionsExample
	{
		const string Text = "{0} is a beautiful country !";

		string PromoteCountry(Func<string, string> func)
		{
			return func("Canada");
		}

		public string Test()
		{
			return PromoteCountry(static country => string.Format(Text, country));
		}
	}
}