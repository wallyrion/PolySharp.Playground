using System.Runtime.CompilerServices;

namespace Polysharp.Playground.CSharp9.CompilerPolyfills
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