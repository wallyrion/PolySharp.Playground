using FluentAssertions;

namespace Polysharp.Playground.CSharp13.RequireRuntime.NewLockObject
{
    public class NewLock
    {
        private readonly Lock _lock = new();
        public int Count { get; private set; }

        public void DoConcurrentOperationWithScope()
        {
            using var scope = _lock.EnterScope();

            Count++;
        } 
       
    }

    public class NewLockTests
    {
        [Fact]
        public void TestWithScope()
        {
            var sut = new NewLock();

            Parallel.For(0, 1000, _ => { sut.DoConcurrentOperationWithScope(); });

            sut.Count.Should().Be(1000);
        } 
        
    }
}