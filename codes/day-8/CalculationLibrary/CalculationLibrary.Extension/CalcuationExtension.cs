using CalculationLibrary;

namespace CalculationLibrary.Extension
{
    public static class CalcuationExtension
    {       
        public static int Multiply(this Calculation calculation, int a, int b)
        {
           return (a * b);
        }
        public static int Divide(this Calculation calculation, int a, int b)
        {
            return (a / b);
        }
    }
}
