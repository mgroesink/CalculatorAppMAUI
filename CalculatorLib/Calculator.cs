namespace CalculatorLib
{
    public static class Calculator
    {
        /// <summary>
        /// Calculates the specified number1.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="operation">The operation.</param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Cannot divide by zero</exception>
        /// <exception cref="System.InvalidOperationException">Invalid Operation</exception>
        public static double Calculate(double number1, double number2, char operation)
        {
            if (number2 == 0 && (operation == '/' || operation == '*'))
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                case '%':
                    result = number1 % number2;
                    break;
                default:
                    throw new InvalidOperationException("Invalid Operation");
            }
            return result;
        }

        /// <summary>
        /// Perform basic calculations on two numbers
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="sum">The sum.</param>
        /// <param name="difference">The difference.</param>
        /// <param name="product">The product.</param>
        /// <param name="quotient">The quotient.</param>
        /// <param name="remainder">The remainder.</param>
        public static void Calculate(double number1,double number2, out double sum,
            out double difference, out double product, out double quotient, out double remainder)
        {
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;
            remainder = number1 % number2;
        }
    }

}
