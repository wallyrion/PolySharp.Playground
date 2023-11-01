using System.Collections.Generic;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class TargetTypedNewExpressionExample
	{
		private List<object> _observations = new();

		public WeatherStation GetStation()
		{
			return new() { Location = "Seattle, WA" };
		}
	}
	
	public class WeatherStation
	{
		public string Location { get; set; }
	}
}