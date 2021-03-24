using System;

namespace Class_Object
{
    
    class Program
    {
        static Trainee GetInput()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Marks: ");
            double marks = double.Parse(Console.ReadLine());

            Console.Write("Department: ");
            string departmentName = Console.ReadLine();

            Trainee traineeObject = new Trainee(id, name, departmentName, marks);
            return traineeObject;
        }
        static void Main()
        {
            //for (int i = 0; i < 2; i++)
            //{
            Trainee traineeeReference = GetInput();
            //traineeeReference.Trainee();
            string information = traineeeReference.GetInfo();
            Console.WriteLine(information);
            //traineeeReference = null;
            //WeakReference<Trainee> weakReference = new WeakReference<Trainee>(traineeeReference);
            //SqlConnection
            //}
            //code
            //traineeeReference.GetInfo();

            GC.Collect();
            GC.Collect();
        }
    }
}
