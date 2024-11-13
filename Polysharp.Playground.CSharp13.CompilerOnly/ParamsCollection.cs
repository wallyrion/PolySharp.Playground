using Xunit;

namespace Polysharp.Playground.CSharp13.CompilerOnly
{
    /// <summary>
/// The <c>params</c> modifier is no longer limited to array types. It now supports a wide range of recognized collection types, 
/// allowing flexibility in method parameter declarations.
/// </summary>
/// <remarks>
/// The <c>params</c> modifier can be applied to various collection types beyond traditional arrays, 
/// including <see cref="System.Span{T}"/>, <see cref="System.ReadOnlySpan{T}"/>, and any types that implement 
/// <see cref="System.Collections.Generic.IEnumerable{T}"/> and have an <c>Add</c> method. 
/// This extension also includes compatibility with the following interfaces:
/// <list type="bullet">
///     <item>
///         <description><see cref="System.Collections.Generic.IEnumerable{T}"/></description>
///     </item>
///     <item>
///         <description><see cref="System.Collections.Generic.IReadOnlyCollection{T}"/></description>
///     </item>
///     <item>
///         <description><see cref="System.Collections.Generic.IReadOnlyList{T}"/></description>
///     </item>
///     <item>
///         <description><see cref="System.Collections.Generic.ICollection{T}"/></description>
///     </item>
///     <item>
///         <description><see cref="System.Collections.Generic.IList{T}"/></description>
///     </item>
/// </list>
/// When an interface type is used with <c>params</c>, the compiler synthesizes the necessary storage for the arguments provided at the call site.
/// </remarks>
/// <example>
/// This expanded support for <c>params</c> allows method declarations to use spans and other collections as parameters:
/// <code>
/// public static void Concat&lt;T&gt;(params ReadOnlySpan&lt;T&gt; items)
/// {
///     for (int i = 0; i &lt; items.Length; i++)
///     {
///         Console.Write(items[i]);
///         Console.Write(" ");
///     }
///     Console.WriteLine();
/// }
/// </code>
/// </example>
/// <see href="https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#params-modifier-for-collection-types">
///     Learn more in the feature specification for params collections.
/// </see>

    public static class ParamsCollectionReadonlySpan
    {
        public static void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
    
    public static class ParamsCollectionIEnumerable
    {
        public static void Concat<T>(params IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
    
    public static class ParamsCollectionList
    {
        public static void Concat<T>(params List<T> items)
        {
            foreach (var item in items)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
    
    
    public class ParamsCollectionTests
    {
	
        [Fact]
        public void TestReadOnlySpan()
        {
            ParamsCollectionReadonlySpan.Concat("Hello", "World", "!");
            ParamsCollectionReadonlySpan.Concat(1, 2, 3, 4, 5);
        }

        [Fact]
        public void TestReadOnlyIEnumerable()
        {
            ParamsCollectionIEnumerable.Concat("Hello", "World", "!");
            ParamsCollectionIEnumerable.Concat(1, 2, 3, 4, 5);
        }

        [Fact]
        public void TestList()
        {
            ParamsCollectionList.Concat("Hello", "World", "!");
            ParamsCollectionList.Concat(1, 2, 3, 4, 5);
        }
    }
}



