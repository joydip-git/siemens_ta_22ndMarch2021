using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSAPP.Entities;

namespace HRMSAPP.UserInterface
{
    class HrmsUi
    {
        static Employee[] CreateRepository()
        {
            Employee[] employees = new Employee[2];
            return employees;
        }
        static Employee CreateRecord()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Project Name: ");
            string projectName = Console.ReadLine();

            Console.Write("Basic Payment: ");
            decimal basicPay = decimal.Parse(Console.ReadLine());

            Console.Write("Da Payment: ");
            decimal daPay = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Payment: ");
            decimal hraPay = decimal.Parse(Console.ReadLine());

            Employee employee = new Employee(employeeName: name, employeeId: id, employeeBasicPayment: basicPay, employeeDaPayemnt: daPay, employeeHraPayment: hraPay);

            return employee;
        }
        static void InsertRecord(Employee[] repository)
        {
            for (int i = 0; i < repository.Length; i++)
            {
                repository[i] = CreateRecord();
                repository[i].CalculateSalary();
            }
        }
        static void Main()
        {
            Employee[] repository = CreateRepository();
            InsertRecord(repository);
            ShowRecords(repository);
        }

        static void ShowRecords(Employee[] repository)
        {
            foreach (Employee employee in repository)
            {
                Console.WriteLine($"Salay of {employee.EmployeeName} is {employee.EmployeeTotalSalary}");
            }
        }
    }
}
