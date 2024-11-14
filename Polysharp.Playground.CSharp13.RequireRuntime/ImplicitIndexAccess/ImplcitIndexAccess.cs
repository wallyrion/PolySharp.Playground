using FluentAssertions;

namespace Polysharp.Playground.CSharp13.RequireRuntime.ImplicitIndexAccess
{
    public class ImplicitIndexAccessTests
    {
        public class TimerRemaining
        {
            public int[] Buffer { get; set; } = new int[12];
        }
        
        [Fact]
        public void Test()
        {
            // Arrange & Act

            var countdown = new TimerRemaining()
            {
                Buffer =
                {
                    [1] = -1,
                    [^1] = 0,
                    [^2] = 1,
                    [^3] = 2,
                    [^4] = 3,
                    [^5] = 4,
                    [^6] = 5,
                    [^7] = 6,
                    [^8] = 7,
                    [^9] = 8,
                    [^10] = 9
                }
            };

            // Assert
            countdown.Buffer.Should().BeEquivalentTo(new List<int> { 0, -1, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
        }
    }

}

