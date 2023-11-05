namespace Polysharp.Playground.CSharp9.CompilerOnly.PointersFeatures
{
	public class NativeIntegersExample
	{
		private readonly nint _i = 5;

		public nint GetI()
		{
			return _i;
		}
		
		public nuint GetU { get; } = 6u;
	}
}