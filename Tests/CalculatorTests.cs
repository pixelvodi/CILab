using Xunit;
using CalculatorModule;

namespace Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            var calc = new Calculator();
            var result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ShouldReturnSum1()
        {
            var calc = new Calculator();
            var result = calc.Add(3, 3);
            Assert.Equal(6, result); // Неправильно, 2+3=5
        }

    }
}
