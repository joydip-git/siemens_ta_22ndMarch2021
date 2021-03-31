using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionClasses
{
    struct MyKeyValuePair<TKey, TValue>
    {
        TKey key;
        TValue value;
        public MyKeyValuePair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TKey Key { get => key; set => key = value; }
        public TValue Value { get => value; set => this.value = value; }
    }
    class MyDictionary<TKey, TValue>
    {
        List<MyKeyValuePair<TKey, TValue>> collection;
        public MyDictionary()
        {
            collection = new List<MyKeyValuePair<TKey, TValue>>();
        }
        public void Add(TKey key, TValue value)
        {
            MyKeyValuePair<TKey, TValue> keyValuePair = new MyKeyValuePair<TKey, TValue>(key, value);
            collection.Add(keyValuePair);
        }
    }
    class Person
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(9);
            numbers.Add(10);
            numbers.Add(13);

            //numbers.Remove();
            //numbers.RemoveAt();
            //index <= number of elements
            //numbers.Insert(4, 123);

            int index = numbers.IndexOf(12);

            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //no Insert method, also no for loop to iterate
            HashSet<int> setOfNumbers = new HashSet<int>();
            setOfNumbers.Add(12);
            setOfNumbers.Add(12);
            setOfNumbers.Add(13);
            Console.WriteLine("\n\n");
            foreach (int item in setOfNumbers)
            {
                Console.WriteLine(item);
            }

            List<Person> people = new List<Person>();
            people.Add(new Person());
            people.Add(new Person());
            */
            //key-->value
            //sessionId --> asdhaG1244HSAVDJASB

            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("two", 12);
            //dictionary.Add("one", 123);

            ////dictionary.Remove("one");

            //foreach (KeyValuePair<string, int> item in dictionary)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
            //}

            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("two", 12);
            sortedList.Add("one", 123);
            //sortedList.ContainsKey("one")
            //if the key exists the value will be updated
            //if the key does not exist then the new key anf the value will be added
            sortedList["three"] = 321;

            //dictionary.Remove("one");

            foreach (KeyValuePair<string, int> item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value:{item.Value}");
            }

            //string str;
            //string[] arr = str.Split(' ', ',', '.');
            //SortedList<string, int> sl = new SortedList<string, int>();
            //foreach (string item in arr)
            //{
            //    if (sl.ContainsKey(item))
            //    {

            //    }else
            //    {

            //    }
            //}
        }
    }
}
