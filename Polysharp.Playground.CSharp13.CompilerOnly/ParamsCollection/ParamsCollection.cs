using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp13.CompilerOnly.ParamsCollection
{
    public static class ParamsCollectionReadonlySpan
    {
        public static string ConcatSpan<T>(params ReadOnlySpan<T> items)
        {
            return string.Join(" ", items.ToArray());
        }
        
        public static string ConcatIEnumerable<T>(params IEnumerable<T> items)
        {
            return string.Join(" ", items);
        }
        
        public static string ConcatList<T>(params List<T> items)
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
            var result1 = ParamsCollectionReadonlySpan.ConcatSpan("Efficient", "Memory", "Usage", "With", "Span");
            result1.Should().Be("Efficient Memory Usage With Span");

            var result2 = ParamsCollectionReadonlySpan.ConcatSpan(10, 20, 30, 40, 50);
            result2.Should().Be("10 20 30 40 50");
        }

        [Fact]
        public void TestIEnumerable()
        {
            // IEnumerable usage allows flexible data sources, such as query results
            var result1 = ParamsCollectionReadonlySpan.ConcatIEnumerable("Hello", "from", "IEnumerable");
            result1.Should().Be("Hello from IEnumerable");

            var result2 = ParamsCollectionReadonlySpan.ConcatIEnumerable(1, 2, 3, 4, 5);
            result2.Should().Be("1 2 3 4 5");
        }

        [Fact]
        public void TestList()
        {
            // Demonstrating List usage with sorting
            var result1 = ParamsCollectionReadonlySpan.ConcatList("Apple", "Bear", "Monkey", "Zebra");
            result1.Should().Be("Apple Bear Monkey Zebra");

            var result2 = ParamsCollectionReadonlySpan.ConcatList(42, 5, 17, 23, 8);
            result2.Should().Be("42 5 17 23 8");
        }
    }

}