namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class NullableExample
	{
		public void Test()
		{
			var o = RecordPerson("John", "Doe");

			o.Name = "2131";
		}


		public void PrintPerson(Person? person)
		{

		}


		public Person RecordPerson(string first, string? last)
		{
			return new Person
			{
				Name = first
			};
		}

		public class Person
		{
			public string Name { get; set; } = null!;
		}
	}
}
