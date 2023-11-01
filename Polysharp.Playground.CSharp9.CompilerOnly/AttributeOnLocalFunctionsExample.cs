using System;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class AttributeOnLocalFunctionsExample
	{
		public void MyMethod()
		{
			[Obsolete("This method is deprecated. Use NewLocalFunction instead.")]
			void DeprecatedLocalFunction()
			{
				// Some logic here...
			}

			void NewLocalFunction()
			{
				// New logic...
			}

			DeprecatedLocalFunction(); // This will produce a warning
		}
	}
}