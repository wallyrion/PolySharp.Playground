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
            string result1 = ParamsCollectionReadonlySpan.Concat("Efficient", "Memory", "Usage", "With", "Span");
            Assert.Equal("Efficient Memory Usage With Span", result1);

            string result2 = ParamsCollectionReadonlySpan.Concat(10, 20, 30, 40, 50);
            Assert.Equal("10 20 30 40 50", result2);
        }

        [Fact]
        public void TestIEnumerable()
        {
            // IEnumerable usage allows flexible data sources, such as query results.
            string result1 = ParamsCollectionIEnumerable.Concat("Hello", "from", "IEnumerable");
            Assert.Equal("Hello from IEnumerable", result1);

            string result2 = ParamsCollectionIEnumerable.Concat(Enumerable.Range(1, 5)); // Outputs 1 to 5
            Assert.Equal("1 2 3 4 5", result2);
        }

        [Fact]
        public void TestList()
        {
            // Demonstrating List usage with sorting
            string result1 = ParamsCollectionList.Concat(new List<string> { "Zebra", "Apple", "Monkey", "Bear" });
            Assert.Equal("Apple Bear Monkey Zebra", result1); // Sorted alphabetically

            string result2 = ParamsCollectionList.Concat(new List<int> { 42, 5, 17, 23, 8 });
            Assert.Equal("5 8 17 23 42", result2); // Sorted numerically
        }
    }
}