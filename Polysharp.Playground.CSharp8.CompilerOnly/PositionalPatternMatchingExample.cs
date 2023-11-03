using System;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	public class PositionalPatternMatchingExample
	{
		public static double GetDiagonalLength(Size s)
		{
			(double w, double h) = s;
			return Math.Sqrt(w * w + h * h);
		}
		
		static string DescribeSize(Size s) => s switch
		{
			(0, 0) => "Empty",
			(0, _) => "Extremely narrow",
			(_, 0) => "Extremely wide",
			_ => "Normal"
		};
		
		public readonly struct Size
		{
			public Size(double w, double h)
			{
				W = w;
				H = h;
			}

			public void Deconstruct(out double w, out double h)
			{
				w = W;
				h = H;
			}

			public double W { get; }
			public double H { get; }
		}
	}
}