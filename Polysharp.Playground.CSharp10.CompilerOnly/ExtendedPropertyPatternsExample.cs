﻿namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class ExtendedPropertyPatternsExample
{
	public class Person
	{
		public string Name { get; set; }
		public Address Address { get; set; }
	}

	public class Address
	{
		public string Street { get; set; }
		public string City { get; set; }
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

		if (john is { Name: "John Doe", Address.City: "Anytown" })
		{
			return true;
		}

		return false;
	}
}