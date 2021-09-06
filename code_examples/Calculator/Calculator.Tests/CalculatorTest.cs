using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, -1, 0)]
        [InlineData(10, 1, 11)]
        public void TestAdd(int arg1, int arg2, int expectedResult)
        {
            var calculator = new Calculator();
            var result = calculator.Add(arg1, arg2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 10, 100)]
        public void TestMultiply(int arg1, int arg2, int expectedResult)
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(arg1, arg2);

            Assert.Equal(expectedResult, result);
        }
    }
}
