using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericTypes
{
    interface ICalculation<T>
    {
        void Add(T a, T b);
    }
    class Calculation<T> : ICalculation<T> where T : struct
    {
        public void Add(T a, T b)
        {

        }
    }

    interface IMyList<T>
    {
        int Capacity { get; }
        int Count { get; }
        void Add(T data);
    }
    class MyList<T> : IMyList<T>
    {
        T[] arr;
        int index = 0;
        public MyList()
        {
            arr = new T[4];
        }
        public int Capacity
        {
            get => arr.Length;
        }
        public int Count
        {
            get => index - 1;
        }
        public void Add(T data)
        {
            if (index == arr.Length)
            {
                T[] temp = new T[arr.Length];
                arr.CopyTo(temp, 0);
                arr = new T[arr.Length * 2];
                temp.CopyTo(arr, 0);
                temp = null;
            }
            arr[index] = data;
            index++;
        }
    }
    class Program
    {
        //T-> Type parameter
        //generic method with constraint
        static void Add<T>(T a, T b) where T : class
        {

        }
        static void Add<T1, T2>(T1 a, T2 b)
        {

        }
        //static void Add(float a, float b)
        //{

        //}
        //static void Add(long a, long b)
        //{

        //}
        static void Main()
        {
            /*
            Add<string>("abc", "def");
            //Add<int>(12, 13);
            //Add<double>(12.34, 34.56);
            Add<int, int>(12, 13);
            Add<double, int>(12.34, 56);

            MyList<int> numbers = new MyList<int>();
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(12);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Capacity);
            */
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            List<int> values = arr.ToList<int>();
            //List<int> values = arr.ToMyList<int>();
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
        }
    }    
    static class ArrayExtension
    {
        public static List<T> ToMyList<T>(this T[] arr)
        {
            List<T> list = new List<T>();
            foreach (T item in arr)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
