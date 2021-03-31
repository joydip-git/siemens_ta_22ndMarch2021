using CalculationLibrary;
using CalculationLibrary.Extension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CalculationClient
{
    class Person
    {

    }
    class PersonCollection : CollectionBase
    {
        Person[] people;

        public PersonCollection()
        {
            people = new Person[4];                   
        }
        public void Add(Person person)
        {

        }
        public void Remove(Person person)
        {

        }
    }
    class Program
    {
        static void Main()
        {
            //PersonCollection personCollection = new PersonCollection();
            //personCollection.Add();
            /*
            Calculation calculation = new Calculation();
            int resAdd = calculation.Add(12, 13);
            int resSub = calculation.Subtract(12, 3);
            int resMulti = calculation.Multiply(12, 13);
            int resDiv = calculation.Divide(12, 3);
            Console.WriteLine(resAdd);

            /*
            int[] arr = new int[4];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30; //0
            arr[3] = 40;//0

            int[] temp = new int[arr.Length];
            arr.CopyTo(temp, 0);

            arr = new int[arr.Length * 2];
            temp.CopyTo(arr, 0);
            */
            
            ArrayList al = new ArrayList();
            al.Add(12); //int x = 12; Object obj = x; al.Add(obj);--> int a = (int)obj; cw(a);
            al.Add('a');
            al.Add("siemens");
            al.Add(23.45);
            //al.Remove(12);
            //al.Sort();
            //al.RemoveAt();
            //al.Insert();
            foreach (Object obj in al)
            {
                Console.WriteLine(obj);
            }

            List<int> numbers = new List<int>();
            numbers.Add(12); //0
            numbers.Add('a'); //1
            numbers.Insert(1, 9);
            //numbers.Remove(12);
            numbers.RemoveAt(0);
            //numbers.RemoveRange(0, 2);
            //numbers.Add("siemens");
            //numbers.Add(23.45);
            numbers.Sort();
            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
            List<string> locations = new List<string>();
            locations.Add("chennai");
            Console.WriteLine(locations.Count);
            locations.Add("mumbai");
            Console.WriteLine(locations.Count);          
            
        }
    }
}
