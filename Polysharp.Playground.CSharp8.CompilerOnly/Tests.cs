using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class Tests
	{
		[Fact]
		public void TargetTypedExample()
		{
			// Arrange
			var target = new TargetTypedExample();

			// Act
			var actualNumber = target.ShowExample(null, 25);

			// Assert
			actualNumber.Should().Be(25);
		}
	}
}