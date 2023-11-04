using FluentAssertions;

namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class Tests
{
	[Fact]
	public void RecordStructExampleTest()
	{
		var point1 = new RecordStructExample.Point(12, 3);
		var point2 = new RecordStructExample.Point(12, 3);

		var equal = point1 == point2;

		equal.Should().BeTrue();
	}

	[Fact]
	public void ExtendedPropertyPatternsExampleTest()
	{
		var example = new ExtendedPropertyPatternsExample();

		example.Test().Should().BeTrue();
	}
}