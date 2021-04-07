using CalculationLibrary;
using NewLibrary;
using System;

namespace Client
{
    class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(12, 13));
            Console.WriteLine(calculation.Multiply(12, 3));
        }
    }
}
