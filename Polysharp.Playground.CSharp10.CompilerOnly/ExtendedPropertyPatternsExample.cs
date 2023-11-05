namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class ExtendedPropertyPatternsExample
{
	public class Person
	{
		public string Name { get; set; } = null!;
		public Address Address { get; set; } = null!;
	}

	public class Address
	{
		public string Street { get; set; } = null!;
		public string City { get; set; } = null!;
	}

	public bool Test()
	{
		Person john = new Person
		{
			Name = "John Doe",
			Address = new Address
			{
				Street = "1234 Main St",
				City = "Anytown"
			}
		};

		return john is { Name: "John Doe", Address.City: "Anytown" };
	}
}