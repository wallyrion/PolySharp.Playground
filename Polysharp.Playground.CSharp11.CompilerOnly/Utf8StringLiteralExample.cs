using System;

namespace Polysharp.Playground.CSharp11.CompilerOnly
{
	public class Utf8StringLiteralExample
	{
		public string Test()
		{
			string str = "Hello world"u8.ToString();
		
			ReadOnlySpan<byte> s2 = "hello"u8;

			byte[] s5 = "hello"u8.ToArray();
		
			return str;
		}
	}
}