using System.Collections.Generic;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class ExtensionGetEnumeratorSupportForeachLoopsExample
	{
		public List<string> Test()
		{
			List<string> res = new List<string>();
			Persons persons = new Persons();
			persons.AddPerson(new Person {Name = "John", Age = 30});
			persons.AddPerson(new Person {Name = "Jane", Age = 28});

			foreach (Person person in persons)
			{
				res.Add(person.Name);
			}

			return res;
		}
		
		public class Person
		{
			public string Name { get; set; } = null!;
			public int Age { get; set; }
		}
		
		public class Persons
		{
			private readonly List<Person> _people = new();

			public void AddPerson(Person person)
			{
				_people.Add(person);
			}

			public List<Person> GetPeople()
			{
				return _people;
			}
		}
		
		
	}
	
	public static class PersonsExtensions
	{
		public static IEnumerator<ExtensionGetEnumeratorSupportForeachLoopsExample.Person> GetEnumerator(this ExtensionGetEnumeratorSupportForeachLoopsExample.Persons persons)
		{
			return persons.GetPeople().GetEnumerator();
		}
	}
}