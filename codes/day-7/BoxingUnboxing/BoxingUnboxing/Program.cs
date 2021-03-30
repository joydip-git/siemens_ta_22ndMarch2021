using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Employee //:Object
    {
        string name;
        int id;
        public Employee()
        {

        }
        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        //public string GetInformation()
        //{
        //    return $"Name:{name}, Id:{id}";
        //}
        public override string ToString()
        {
            return $"Name:{name}, Id:{id}";
            //return this.GetType().Name;
        }
    }
    class Program
    {
        static void Main()
        {
            int a = 12;
            Console.WriteLine(a);

            //Boxing (VT --> RT)
            object obInt = a;
            Console.WriteLine(obInt);

            //Unboxing (RT --> same VT)
            //int b = obInt as int;<--as operator is used to cast to reference type NOT to value type
            //int b = (int)obInt; <-- casting possible
            int b = Convert.ToInt32(obInt); //<-- Convert class's method is possible
            Console.WriteLine(b);

            Employee anilEmployee = new Employee("anil", 1);
            //string info = anilEmployee.ToString();
            //Console.WriteLine(info);
            Console.WriteLine(anilEmployee);
            GetTypeInfo(anilEmployee);          
        }
        static void GetTypeInfo(Employee employee)
        {
            Type anilType = employee.GetType();
            Console.WriteLine($"Name: " + anilType.Name);
            Console.WriteLine($"Is class?: " + anilType.IsClass);
            Console.WriteLine($"Is Interface: " + anilType.IsInterface);
            Console.WriteLine($"App: " + anilType.FullName);
        }
    }
}
