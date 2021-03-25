using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArray
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[2, 3];
            arr[0, 0] = 10;
            arr[0, 1] = 20;
            arr[0, 2] = 30;

            arr[1, 0] = 40;
            arr[1, 1] = 50;
            arr[1, 2] = 60;

            Console.WriteLine($"Rank: {arr.Rank}");
            Console.WriteLine($"Length of Rank:0 is {arr.GetLength(0)}");
            Console.WriteLine($"Length of Rank:1 is {arr.GetLength(1)}");

            /*
            for (int rowIndex = 0; rowIndex < 2; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    Console.WriteLine(arr[rowIndex, columnIndex]);
                }
            }
            */
            for (int rowIndex = 0; rowIndex < arr.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < arr.GetLength(1); columnIndex++)
                {
                    Console.WriteLine($"Value at arr[{rowIndex},{columnIndex}]={arr[rowIndex, columnIndex]}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
