using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp8.RequirePolyfills
{
	public class Tests
	{
		[Fact]
		public void IndicesAndRangesExampleTestRange()
		{
			// Arrange
			var target = new IndicesAndRangesExample();

			var res = target.GetSubString("Hello World", 6, 1);
			// Act
			res.Should().Be("Worl");
		}
		
		[Fact]
		public void IndicesAndRangesExampleTestRange2()
		{
			// Arrange
			var target = new IndicesAndRangesExample();

			var res = target.GetBeforeIndexFromEnd("Hello World", 1);
			// Act
			res.Should().Be("Hello Worl");
		}

	}
}