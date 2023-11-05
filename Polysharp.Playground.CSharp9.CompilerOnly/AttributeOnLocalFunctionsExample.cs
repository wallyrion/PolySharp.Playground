using System;

namespace Polysharp.Playground.CSharp9.CompilerOnly
{
	public class AttributeOnLocalFunctionsExample
	{
		[Obsolete("Obsolete")]
		public void MyMethod()
		{
			[Obsolete("This method is deprecated. Use NewLocalFunction instead.")]
			void DeprecatedLocalFunction()
			{
				// Some logic here...
			}

			DeprecatedLocalFunction(); // This will produce a warning
		}
	}
}