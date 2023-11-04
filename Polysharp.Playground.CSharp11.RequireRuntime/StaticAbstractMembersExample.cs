namespace Polysharp.Playground.CSharp11.RequireRuntime;

public class StaticAbstractMembersExample
{
	interface IAddable<T> where T : IAddable<T>
	{
		static abstract T Zero { get; }
		static abstract T operator +(T t1, T t2);
	}
}