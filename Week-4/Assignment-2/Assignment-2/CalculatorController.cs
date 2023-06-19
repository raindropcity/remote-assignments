using Assignment_2.Interfaces;

namespace Assignment_2
{
    public class CalculatorController
    {
        private readonly ICalculator _calculator;
        private readonly string _calculatorType;

        public CalculatorController(ICalculator calculator, string calculatorType)
        {
            _calculator = calculator;
            _calculatorType = calculatorType;
        }

        public void Calculate(int a, int b)
        {
            Console.WriteLine($"Calculating with \"{_calculatorType}\" method");

            if (_calculatorType == "SimpleAdd")
            {
                Console.WriteLine($"Result: {_calculator.Add(a, b)}");
            }
            else if (_calculatorType == "SimpleSubtract")
            {
                Console.WriteLine($"Result: {_calculator.Subtract(a, b)}");
            }
        }
    }
}
