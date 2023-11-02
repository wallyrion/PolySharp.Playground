namespace Polysharp.Playground.CSharp9.RequireRuntime
{
	public class CovariantReturnTypesExample
	{
		public void Test()
		{
			Animal animal = new Lion();
			Animal mate = animal.Mate();
		}
		
		public class Animal
		{
			public virtual Animal Mate()
			{
				return new Animal();
			}
		}

		public class Lion : Animal
		{
			// Lion is a subclass of Animal
			// So we can use Lion as return type instead of Animal
			public override Lion Mate()
			{
				return new Lion();
			}
		}
	}
}