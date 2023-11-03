using System.Runtime.CompilerServices;

namespace Polysharp.Playground.CSharp9.RequirePolyfills
{
	public class SuppressEmittingLocalInitExample
	{
		[SkipLocalsInit]
		unsafe class Example
		{
			public int x;

		}
	}
}