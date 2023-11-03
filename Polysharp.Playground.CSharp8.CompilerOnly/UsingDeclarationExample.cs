using System;
using System.IO;

namespace Polysharp.Playground.CSharp8.CompilerOnly
{
	class UsingDeclarationExample
	{
		public void ReadFile()
		{
			using SomeDisposable disposable = new SomeDisposable();
		}
		
		public class SomeDisposable : IDisposable
		{
			public void Dispose()
			{
				Console.WriteLine("SomeDisposable.Dispose");
			}
		}
	}
}