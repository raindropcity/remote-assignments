using Microsoft.Extensions.DependencyInjection;
using Assignment_2;
using Assignment_2.Interfaces;
using Assignment_2.Implementations;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
                                .AddTransient<ICalculator, SimpleCalculator>()
                                .BuildServiceProvider();

        var calculator = serviceProvider.GetService<ICalculator>();
        var calculatorType = "SimpleSubtract";

        var calculatorController = new CalculatorController(calculator, calculatorType);

        calculatorController.Calculate(20, 10);

        // using the line below in order to keep the console open
        Console.ReadLine();
    }
}