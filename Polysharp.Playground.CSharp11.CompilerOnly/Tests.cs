using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Polysharp.Playground.CSharp11.CompilerOnly
{
	public class Tests
	{
		[Fact]
		public void RawStringLiteralsExampleTest()
		{
			var example = new RawStringLiteralsExample();

			var json = example.GetJson("John", "Doe");

			var result = JsonConvert.DeserializeObject<RawStringLiteralsExample.Person>(json);

			result!.FirstName.Should().Be("John");
			result.LastName.Should().Be("Doe");
		}

	}
}