using CalculatorLib;
using Xunit;

namespace CalculatorAppTest
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(5, 3, '+', 8)]
        [InlineData(5, 3, '-', 2)]
        [InlineData(5, 3, '*', 15)]
        [InlineData(6, 3, '/', 2)]
        [InlineData(7, 3, '%', 1)]
        public void Calculate_WithValidOperations_ReturnsExpectedResult(double number1, double number2, char operation, double expected)
        {
            // Act
            double result = Calculator.Calculate(number1, number2, operation);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double number1 = 10;
            double number2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Calculate(number1, number2, '/'));
        }

        [Fact]
        public void Calculate_ModulusByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double number1 = 10;
            double number2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Calculate(number1, number2, '%'));
        }

        [Fact]
        public void Calculate_InvalidOperation_ThrowsInvalidOperationException()
        {
            // Arrange
            double number1 = 10;
            double number2 = 5;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Calculator.Calculate(number1, number2, '^'));  // Invalid operation '^'
        }

        [Fact]
        public void Calculate_OutParameters_ReturnsCorrectResults()
        {
            // Arrange
            double number1 = 10;
            double number2 = 3;
            double sum, difference, product, quotient, remainder;

            // Act
            Calculator.Calculate(number1, number2, out sum, out difference, out product, out quotient, out remainder);

            // Assert
            Assert.Equal(13, sum);
            Assert.Equal(7, difference);
            Assert.Equal(30, product);
            Assert.Equal(10 / 3.0, quotient);
            Assert.Equal(10 % 3, remainder);
        }
    }
}