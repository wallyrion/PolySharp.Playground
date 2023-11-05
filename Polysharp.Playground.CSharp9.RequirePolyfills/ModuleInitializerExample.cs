using System.Runtime.CompilerServices;

namespace Polysharp.Playground.CSharp9.RequirePolyfills
{
	public class ModuleInitializerExample
	{
		public static string SomeField { get; set; } = null!;

		[ModuleInitializer]
		internal static void Initialize()
		{
			SomeField = "something";
		}
	}
}