using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSApp
{
    class Program
    {
        static Employee CreateEmployee()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Project Name: ");
            string projectName = Console.ReadLine();

            Console.Write("Basic Pay: ");
            decimal basicPayment = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            decimal daPayment = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            decimal hraPayment = decimal.Parse(Console.ReadLine());

            //C#-4.0: named arguments (.Net Framework 4.0 - 2010)
            Employee employeeReference = new Employee(employeeName: name, employeeId: id, employeeBasicPayment: basicPayment, employeeDaPayemnt: daPayment, employeeProjectName: projectName, employeeHraPayment: hraPayment);

            return employeeReference;
        }
        static void PrintEmployeeInformation(Employee employee)
        {
            employee.CalculateSalary();
            string information = employee.GetInformation();
            Console.WriteLine(information);
        }
        static void Main()
        {
            Employee employeeObjRef = CreateEmployee();
            PrintEmployeeInformation(employeeObjRef);
        }
    }
}
