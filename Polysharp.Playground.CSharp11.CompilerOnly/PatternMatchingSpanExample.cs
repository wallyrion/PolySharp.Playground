// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
#pragma warning disable CS8321 // Local function is declared but never used
namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class PatternMatchingSpanExample
{
	public void Test()
	{
		static bool Is123(ReadOnlySpan<char> s)
		{
			return s is "123";
		}

		static bool IsAbc(Span<char> s)
		{
			return s switch { "ABC" => true, _ => false };
		}
	}
}