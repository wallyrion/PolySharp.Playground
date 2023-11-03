using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp8.CompilerOnly
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

		[Fact]
		public void StaticLocalFunctionExampleTest()
		{
			var example = new StaticLocalFunctionExample();
			example.Test().Should().BePositive();
		}

		[Fact]
		public void SwitchExpressionExample()
		{
			var example = new SwitchExpressionsExample();
			
			example.GetCSharpVersion("8").Should().Be("c# 12");
		}

		[Fact]
		public void NullCoalescingAssignmentExampleTest()
		{
			var example = new NullCoalescingAssignmentExample();
			example.Test(null).Should().NotBeEmpty();
		}
		
		[Fact]
		public void ReadonlyMembersExampleTest()
		{
			var example = new ReadonlyMembersExample();
			var str = example.ToString();

			str.Should().NotBeEmpty();
		}
	}
}