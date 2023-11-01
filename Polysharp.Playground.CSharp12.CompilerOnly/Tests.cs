using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp12.CompilerOnly
{
	public class Tests
	{
		[Fact]
		public void CollectionExpressionExampleTest()
		{
			CollectionExpressionExample.Test().Should().NotBeEmpty();
		}

		[Fact]
		public void PrimaryConstructorsExampleTest()
		{
			var example = new PrimaryConstructorsExample("John", "Doe");

			example.GetFullName().Should().Be("John Doe");
		}

		[Fact]
		public void AliasAnyTypeExampleTest()
		{
			var example = new AliasAnyTypeExample();

			var result = example.Test((3, 5));

			result.Should().Be(8);
		}

	
	}
}