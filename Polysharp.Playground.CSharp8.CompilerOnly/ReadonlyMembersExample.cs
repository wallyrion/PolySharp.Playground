using System;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public struct ReadonlyMembersExample
	{
		public double X { get; set; }
		public double Y { get; set; }

		public readonly double Distance => Math.Sqrt(X * X + Y * Y);

		public readonly override string ToString() =>
			$"({X}, {Y}) is {Distance} from the origin";
		
		/*In this example, Distance and ToString() are readonly members of a struct. This signals that these members do not modify the state of the struct.*/
	}
}