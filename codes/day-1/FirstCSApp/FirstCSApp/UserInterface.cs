using System;
using MessengerApp;

//[CLSCompliant(true)]
namespace FirstCSApp
{
    class UserInterface
    {
        //entrypoint
        //static int Main()
        //{
        //    Console.WriteLine("Hello Guys...");
        //    return 0;
        //}
        //static void Main(string[] args)
        //{
        //    foreach (string item in args)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("Hello Guys...");
        //}
        static void Main()
        {
            //Int32 x = 20;
            //int number = 10;
            //Console.WriteLine(number);
            Console.WriteLine("Hello Guys...");
            string message = Messenger.GetMessage("joydip");
            Console.WriteLine(message);
        }
    }
}
