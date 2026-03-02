using Xunit;
using CalculatorModule;
using GreetingModule;

namespace Tests
{
    public class IntegrationTests
    {
        [Fact]
        public void CalculatorAndGreeter_ShouldWorkTogether()
        {
            var calc = new Calculator();
            var greeter = new Greeter();

            int sum = calc.Add(10, 20);
            string message = greeter.Greet($"User {sum}");

            Assert.Equal("Hello, User 30!", message);
        }
    }
}
