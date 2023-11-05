using System.Text;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class InterpolatedStringImprovements
{
	public void Legacy()
	{
		// Legacy way of doing interpolation and appending to StringBuilder
		StringBuilder sb = new StringBuilder();
		string name = "John";
		sb.AppendFormat($"Hello, {name}!");
	}

	public void NewWay()
	{
		// New way using C# 10 syntax with string interpolation
		StringBuilder sb = new StringBuilder();
		string name = "John";
		sb.AppendFormat($"Hello, {name}!");
	}

	/*In the example, when the interpolated string is evaluated, a string needs to be created. With the improvements in C# 10, the initialization of the InterpolatedStringBuilder type avoids creating the string and directly appends to StringBuilder, saving memory allocations.
		However, these improvements are under the hood and you won't see any explicit new APIs for StringBuilder. The code you write remains the same as you've done before.*/
}