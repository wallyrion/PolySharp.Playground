namespace Polysharp.Playground.CSharp11.CompilerOnly;

public class PatternMatchingSpanExample
{
	public void Test()
	{
		static bool Is123(ReadOnlySpan<char> s)
		{
			return s is "123";
		}

		static bool IsABC(Span<char> s)
		{
			return s switch { "ABC" => true, _ => false };
		}
	}
}