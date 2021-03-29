using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaApp
{
    interface IDataAccess
    {
        string Path { get; set; }
        string GetData();
    }
    class SqlDataAccess : IDataAccess
    {
        string databasePath;

        public string Path { get => databasePath; set => databasePath = value; }

        public string GetData()
        {
            return "Database data";
        }
    }
    class TextFileDataAccess : IDataAccess
    {
        string filePath;

        public string Path { get => filePath; set => filePath = value; }

        public string GetData()
        {
            return "text file data";
        }
    }
    class Program
    {
        /*
        static void PrintMenu()
        {
            Console.WriteLine("1. access data from database");
            Console.WriteLine("2. access data from file");
        }
        static int GetChoice()
        {
            Console.Write("Enter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        private static string GetPath()
        {
            Console.Write("Enter Path: ");
            return Console.ReadLine();
        }
        static void GetDataFromPath(IDataAccess dataAccess, string path)
        {
            dataAccess.Path = path;
            string data = dataAccess.GetData();
            Console.WriteLine(data);
        }
        */

        static void PrintMenu()
        {
            Console.WriteLine("1. Calculate area of circle");
            Console.WriteLine("2. Calculate area of triangle");
        }
        static int GetChoice()
        {
            Console.Write("Enter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static IShape CreateShape(int choice)
        {
            IShape shape = null;
            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case 2:
                    Console.Write("\nEnter Base: ");
                    double tBase = double.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    double tHeight = double.Parse(Console.ReadLine());
                    shape = new Triangle(tBase, tHeight);
                    break;

                default:
                    Console.WriteLine("\nEnter proper choice");
                    break;
            }
            return shape;
        }
        static void PrintArea(IShape shape)
        {
            double area = shape.CalculateArea();
            Console.WriteLine($"Area of {shape.GetType().Name} is {area}");
        }
        static void Main()
        {
            PrintMenu();
            int choie = GetChoice();
            IShape shape = CreateShape(choie);
            PrintArea(shape);
            /*
            PrintMenu();
            int choice = GetChoice();
            IDataAccess dataAccess = null;
            string path = GetPath();
            switch (choice)
            {
                case 1:                    
                    dataAccess = new SqlDataAccess();                   
                    break;

                case 2:
                    dataAccess = new TextFileDataAccess();
                    break;

                default:
                    break;
            }
            
            GetDataFromPath(dataAccess,path);
            */

        }
    }
}
