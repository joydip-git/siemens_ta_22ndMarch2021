using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AarrayOfArraysDemo
{
    class Program
    {
        static void Main()
        {
            int[][] jagged = new int[3][];

            int[] arr1 = new int[] { 10, 20 };
            int[] arr2 = new int[] { 30, 40, 50 };
            int[] arr3 = new int[] { 60, 70, 80, 90 };

            jagged[0] = arr1;
            jagged[1] = arr2;
            jagged[2] = arr3;

            for (int jaggedIndex = 0; jaggedIndex < jagged.Length; jaggedIndex++)
            {
                //int[] a = jagged[jaggedIndex];
                //for (int index = 0; index < a.Length; index++)
                //{
                //    Console.WriteLine(a[index]);
                //}
                for (int index = 0; index < jagged[jaggedIndex].Length; index++)
                {
                    Console.WriteLine($"Value at Jagged[{jaggedIndex}][{index}]={jagged[jaggedIndex][index]}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
