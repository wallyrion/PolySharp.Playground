using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp9.CompilerPolyfills
{
	public class Tests
	{
		[Fact]
		public void RecordsExample()
		{
			var record = new PositionalPropertiesExample("John", "Doe");
			var record2 = new PositionalPropertiesExample("John", "Doe");
			
			record.FirstName.Should().Be("John");

			record.Should().Be(record2);
		}	
		
		[Fact]
		public void InitOnlySettersExample()
		{
			var record = new InitOnlySettersExample
			{
				FirstName = "John"
			};
			
			record.FirstName.Should().Be("John");
		}
		
		[Fact]
		public void CallerArgumentExpressionAttributeExample()
		{
			var mySuperObject = new object();
			var example = new CallerArgumentExpressionExample();

			example.Test(mySuperObject).Should().Be("mySuperObject");
		}

		[Fact]
		public void ModuleInitializerExampleTest()
		{
			ModuleInitializerExample.SomeField.Should().NotBeEmpty();
		}

	}
}