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
            Console.WriteLine($"Calculating {_calculatorType}...");
            Console.WriteLine($"Result: {(_calculatorType == "Simple" ? _calculator.Add(a, b) : _calculator.Subtract(a, b))}");
        }
    }
}
