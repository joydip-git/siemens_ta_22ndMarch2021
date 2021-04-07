using OldLibrary;

namespace NewLibrary
{
    public static class CalculationExtension
    {
        public static int Multiply(this ICalculation calculation, int x, int y)
        {
            return (x * y);
        }
        public static int Divide(this ICalculation calculation, int x, int y)
        {
            return (x / y);
        }
    }
}
