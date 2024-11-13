using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp13.CompilerOnly.ParamsCollection
{
    public static class ParamsCollectionReadonlySpan
    {
        /// <summary>
        /// Concatenates items from a <see cref="ReadOnlySpan{T}"/> and returns them as a single string with a space separator.
        /// Useful for high-performance operations without allocations, such as processing data buffers.
        /// </summary>
        public static string Concat<T>(params ReadOnlySpan<T> items)
        {
            return string.Join(" ", items.ToArray());
        }
    }

    public static class ParamsCollectionIEnumerable
    {
        /// <summary>
        /// Concatenates items from an <see cref="IEnumerable{T}"/> collection and returns them as a single string with a space separator.
        /// This example leverages deferred execution, allowing for flexible data sources such as LINQ queries.
        /// </summary>
        public static string Concat<T>(params IEnumerable<T> items)
        {
            return string.Join(" ", items);
        }
    }

    public static class ParamsCollectionList
    {
        /// <summary>
        /// Concatenates items from a <see cref="List{T}"/>, providing explicit control over the list’s items.
        /// This example is useful for scenarios where items may need modification or sorting before concatenation.
        /// </summary>
        public static string Concat<T>(params List<T> items)
        {
            return string.Join(" ", items);
        }
    }

    public class ParamsCollectionTests
    {
        [Fact]
        public void TestReadOnlySpan()
        {
            // Using ReadOnlySpan to efficiently process a block of text data
            var result1 = ParamsCollectionReadonlySpan.Concat("Efficient", "Memory", "Usage", "With", "Span");
            result1.Should().Be("Efficient Memory Usage With Span");

            var result2 = ParamsCollectionReadonlySpan.Concat(10, 20, 30, 40, 50);
            result2.Should().Be("10 20 30 40 50");
        }

        [Fact]
        public void TestIEnumerable()
        {
            // IEnumerable usage allows flexible data sources, such as query results
            var result1 = ParamsCollectionIEnumerable.Concat("Hello", "from", "IEnumerable");
            result1.Should().Be("Hello from IEnumerable");

            var result2 = ParamsCollectionIEnumerable.Concat(Enumerable.Range(1, 5));
            result2.Should().Be("1 2 3 4 5");
        }

        [Fact]
        public void TestList()
        {
            // Demonstrating List usage with sorting
            var result1 = ParamsCollectionList.Concat(new List<string> { "Zebra", "Apple", "Monkey", "Bear" });
            result1.Should().Be("Apple Bear Monkey Zebra");

            var result2 = ParamsCollectionList.Concat(new List<int> { 42, 5, 17, 23, 8 });
            result2.Should().Be("5 8 17 23 42");
        }
    }

}