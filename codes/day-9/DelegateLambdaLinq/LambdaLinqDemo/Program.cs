using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqDemo
{
    //1. declare a delegate to provide prototype of the function
    //delegate bool LogicDel(int x);
    //delegate bool Predicate(object x);
    // delegate bool LogicDel<in T>(T x);
    delegate TResult LogicDel<in T, out TResult>(T x);

    //class LogicDel:MulticastDelegate:Delegate
    //{
    //    MethodInfo _method;
    //    object _target;
    //    public LogicDel(object target, MethodInfo method)
    //    {
    //      _method = method;
    //      _target = target;
    //    }

    //    public bool Invoke(int x)
    //    {
    //       _method.Invoke(_target,new object[]{x});        
    //    }
    //}

    class Logic
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public bool IsGreaterThanFive(int number)
        {
            return number > 5;
        }
        public bool IsLessrThanThree(int number)
        {
            return number < 3;
        }
        //public bool IsGreaterThanFour(int number)
        //{
        //    return number > 4;
        //}
    }
    class Program
    {
        static List<int> Filter(List<int> input, LogicDel<int, bool> logic)
        {
            List<int> result = new List<int>();
            foreach (int item in input)
            {
                bool status = logic(item);
                if (status)
                    result.Add(item);
            }
            return result;
        }
        static void Main()
        {
            //public delegate bool Predicate<in T>(T obj);
            //Predicate<int> evenLogic = (x) => x % 2 == 0;

            //public delegate TResult Func<in T, out TResult>(T arg);
            Func<int, bool> oddlogic = (num) => num % 2 != 0;
            List<int> numbers = new List<int> { 1, 3, 4, 2, 6, 5, 9, 7, 0, 8 };

            //Method query syntax
            //var resultOP = numbers.Where(oddlogic).OrderBy(num => num).ToList<int>();
            
            //query syntax
            var resultOP = from num in numbers
                           where num % 2 == 0
                           orderby num ascending
                           select num;

            foreach (int item in resultOP)
            {
                Console.WriteLine(item);
            }

            //2. create an object of delegate and pass the function to the constructor of the delegate
            Logic logicCls = new Logic();
            //logic.IsEven()
            //LogicDel oddLogic = new LogicDel(logic.IsLessrThanThree);
            //bool isEven = evenLogic.Invoke(12);
            //Console.WriteLine(isEven);

            //LogicDel logic = public bool IsGreaterThanFour(int number)
            //{
            //    return number > 4;
            //};

            //anonymous method
            //LogicDel logic = delegate (int number)
            //{
            //    return number > 4;
            //};

            //anonymous method through Lambda Expression
            // (args) =>(expression) <-- Lambda operator
            LogicDel<int, bool> logic = (number) => number > 4;

            //var result = Filter(numbers, oddLogic);
            var result = Filter(numbers, logic);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
