using OldLibrary;

namespace CalculationLibrary
{
    public class Calculation : ICalculation
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }

        public int Subtract(int a, int b)
        {
            return (a - b);
        }
    }
}
