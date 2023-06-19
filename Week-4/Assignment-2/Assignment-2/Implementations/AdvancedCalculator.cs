using Assignment_2.Interfaces;

namespace Assignment_2.Implementations
{
    public class AdvancedCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return (a + b) * 2;
        }

        public int Subtract(int a, int b)
        {
            return (a - b) * 2;
        }
    }
}
