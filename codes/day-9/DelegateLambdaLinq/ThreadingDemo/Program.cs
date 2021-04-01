using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Program
    {
        static void Read()//Foo1
        //static void Read(object count)//Foo1
        {
            Console.WriteLine($"Read Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //for (int i = 0; i < (int)count; i++)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Read: I:{i}");
            }
        }
        static void Write()
        //static void Write(object count)
        {
            Console.WriteLine($"Write Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //for (int i = 0; i < (int)count; i++)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Write: I:{i}");
            }
        }
        static void Main() //Foo
        {
            Thread someThread = new Thread((count) =>
            {
                for (int i = 0; i < (int)count; i++)
                {
                    Console.WriteLine(i);
                }
            });
            someThread.Priority = ThreadPriority.Highest;
            /*
            Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            //ThreadStart readDelegate = new ThreadStart(Program.Read);
            //ThreadStart writeDelegate = new ThreadStart(Program.Write);

            ParameterizedThreadStart readDelegate = new ParameterizedThreadStart(Program.Read);
            ParameterizedThreadStart writeDelegate = new ParameterizedThreadStart(Program.Write);

            Thread threadRead = new Thread(readDelegate);//reference to a method
            Thread threadWrite = new Thread(writeDelegate);//reference to a method

            //threadRead.Start();   //Read();
            //threadWrite.Start();  //Write();

            threadRead.Start(4);   // readDelegate(4)-->Read(4);
            threadRead.Join();


            threadWrite.Start(3);  // writeDelegate(3)-->Write(3);          
            threadWrite.Join();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main: I:{i}");
            }
            */

            //public delegate void Action();
            Action readAction = new Action(Read);
            Action writeAction = new Action(Write);

            //public delegate void Action<in T>(T obj);
            //Action<int> read = (x) => Console.WriteLine(x);
            //Action<string> write = (name) => Console.WriteLine(name);
            
            Task.Run(readAction);
            Task.Run(writeAction);

            Action someAction = () => Console.WriteLine("any method");
            Action someOtherAction = delegate ()
            {
                Console.WriteLine("some other method");
            };

            //Task.Run(someAction);
            Task.Run(() => Console.WriteLine("directly passing anonymus method to task's run method"));

            Console.Read();
        }
    }
}
