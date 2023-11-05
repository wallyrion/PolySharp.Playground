
namespace Polysharp.Playground.CSharp10.CompilerOnly;

// ReSharper disable once UnusedType.Global
public class ImplicitUsingExample
{
	// do not need to include using System.Collections.Generic 
	public List<string> Test()
	{
		return new List<string>();
	}
}