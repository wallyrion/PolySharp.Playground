namespace Polysharp.Playground.CSharp10.CompilerOnly;

public class ConstantInterpolatedStringExample
{
	private const string LastName = "Test";
	public const string Name = $"{nameof(ConstantInterpolatedStringExample)} {LastName}";
}