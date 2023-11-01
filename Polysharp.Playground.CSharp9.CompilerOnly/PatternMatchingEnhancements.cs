namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public static class PatternMatchingEnhancements
	{
		public static bool IsLetter(this char c) =>
			c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
		
		public static bool IsLetterOrSeparator(this char c) =>
			c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

		public static bool IsNotNull(this object? o)
		{
			return o is not null;
		}
	}
}