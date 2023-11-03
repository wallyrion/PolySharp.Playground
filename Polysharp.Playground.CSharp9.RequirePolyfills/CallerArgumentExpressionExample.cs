using System.Runtime.CompilerServices;

namespace Polysharp.Playground.CSharp9.RequirePolyfills
{
	public class CallerArgumentExpressionExample
	{
		public string Test(object someObject, [CallerArgumentExpression("someObject")] string? objectName = null)
		{
			// objectName will be the name of the variable passed to the method, in this case "mySuperObject"
			return objectName!;
		}
	}
}