using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSApp
{
    class Employee
    {
        int employeeId;
        string employeeName;
        string employeeProjectName;
        decimal employeeBasicPayment;
        decimal employeeDaPayemnt;
        decimal employeeHraPayment;
        decimal employeeTotalSalary;

        public Employee()
        {

        }

        public Employee(int employeeId, string employeeName, string employeeProjectName, decimal employeeBasicPayment, decimal employeeDaPayemnt, decimal employeeHraPayment)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeProjectName = employeeProjectName;
            this.employeeBasicPayment = employeeBasicPayment;
            this.employeeDaPayemnt = employeeDaPayemnt;
            this.employeeHraPayment = employeeHraPayment;
        }

        public decimal CalculateSalary()
        {
            employeeTotalSalary = employeeBasicPayment + employeeDaPayemnt + employeeHraPayment;
            return employeeTotalSalary;
        }
        public string GetInformation()
        {
            //string template/ templated string/ string interpolation
            //C# 6.0 - .Net Frameowrk 4.6
            return $"Name:{this.employeeName}, Id: {employeeId}, Project: {employeeProjectName}, Salary:{employeeTotalSalary}";
        }
    }
}
