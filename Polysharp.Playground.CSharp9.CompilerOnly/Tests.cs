using FluentAssertions;
using Polysharp.Playground.CSharp9.CompilerOnly.CustomPolyfils;
using Xunit;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class Tests
	{
		[Fact]
		public void PatternMatchingEnhancements_IsLetter()
		{
			'd'.IsLetter().Should().BeTrue();
			']'.IsLetter().Should().BeFalse();
		}
		
		[Fact]
		public void PatternMatchingEnhancements_IsLetterOrSeparator()
		{
			'd'.IsLetterOrSeparator().Should().BeTrue();
			']'.IsLetterOrSeparator().Should().BeFalse();
			'.'.IsLetterOrSeparator().Should().BeTrue();
		}
		
		[Fact]
		public void PatternMatchingEnhancements_IsNotNull()
		{
			object? o = null;

			o.IsNotNull().Should().BeFalse();

			o = new object();

			o.IsNotNull().Should().BeTrue();
		}	
		
		[Fact]
		public void StaticAnonymousFunctions()
		{
			var example = new StaticAnonymousFunctionsExample();
			var result = example.Test();

			result.Should().NotBeEmpty();
		}

		[Fact]
		public void ExtensionGetEnumeratorSupportForeachLoopsExample()
		{
			var example = new ExtensionGetEnumeratorSupportForeachLoopsExample();
			example.Test().Should().NotBeEmpty();
		}

		[Fact]
		public void RecordsExampleTest()
		{
			var record1 = new RecordsExample
			{
				FirstName = "John",
				LastName = "Doe"
			};
			var record2 = new RecordsExample
			{
				FirstName = "John",
				LastName = "Doe"
			};

			var equal = record1 == record2;

			equal.Should().BeTrue();

			record1.Should().Be(record2);
		}

		[Fact]
		public void CustomPolyfilsExampleTest()
		{
			var example = new CustomPolyfilsExample();

			example.Test().Should().NotBeEmpty();
		}
	}
}