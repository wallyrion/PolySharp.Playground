using System.Runtime.CompilerServices;
// ReSharper disable InconsistentNaming
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value

namespace Polysharp.Playground.CSharp9.RequirePolyfills
{
	// ReSharper disable once UnusedType.Global
	public class SuppressEmittingLocalInitExample
	{
		[SkipLocalsInit]
		// ReSharper disable once UnusedType.Local
		class Example
		{
			public int x;
		}
	}
}