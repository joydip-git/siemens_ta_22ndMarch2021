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

            Trainee traineeObject = new Trainee(id);
            //Trainee traineeObject = new Trainee(id);
            traineeObject.TraineeName = name;
            traineeObject.TraineeDepartmentName = departmentName;
            traineeObject.TraineeMarks = marks;
            return traineeObject;
        }
        static void Main()
        {
            Trainee traineeRef = GetInput();
            //traineeRef.SetDepartment("Training");
            traineeRef.TraineeDepartmentName = "Training"; //calling set
            Console.WriteLine(traineeRef.TraineeDepartmentName); //calling get
            Console.WriteLine(traineeRef.GetInfo());
        }
    }
}
