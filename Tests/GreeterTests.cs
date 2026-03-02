using Xunit;
using GreetingModule;

namespace Tests
{
    public class GreeterTests
    {
        [Fact]
        public void Greet_ShouldReturnHello()
        {
            var greeter = new Greeter();
            var result = greeter.Greet("World");
            Assert.Equal("Hello, World!", result);
        }
    }
}
