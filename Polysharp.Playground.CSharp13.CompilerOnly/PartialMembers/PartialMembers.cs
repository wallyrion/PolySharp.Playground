using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp13.CompilerOnly.PartialMembers
{
    public partial class C
    {
        // Declaring declaration
        public partial string Name { get; set; }
    }

    public partial class C
    {
        // implementation declaration:
        private string _name = null!;
        public partial string Name
        {
            get => _name;
            set => _name = value + DateTime.Today;
        }
    }


    public class PartialMembersTests
    {
        [Fact]
        public void Test()
        {
            var c = new C { Name = "Hello" };
            c.Name.Should().Be("Hello" + DateTime.Today);
        }
    }
}