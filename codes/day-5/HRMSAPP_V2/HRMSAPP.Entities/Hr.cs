using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSAPP.Entities
{
    public class Hr : Employee
    {
        decimal gratuityPayment;
        public Hr()
        {

        }
        public Hr(int employeeId, string employeeName = null, string employeeProjectName = null, decimal employeeBasicPayment = 0, decimal employeeDaPayemnt = 0, decimal employeeHraPayment = 0, decimal gratuityPayment = 0)
            : base(employeeId: employeeId, employeeName: employeeName, employeeProjectName: employeeProjectName, employeeHraPayment: employeeHraPayment, employeeDaPayemnt: employeeDaPayemnt, employeeBasicPayment: employeeBasicPayment)
        {
            this.gratuityPayment = gratuityPayment;
        }
        public void CalculateSalary()
        {
            base.CalculateSalary();
            EmployeeTotalSalary = EmployeeTotalSalary + gratuityPayment;
            //return employeeTotalSalary;
        }
        //public string GetInformation()
        //{
        //    //string template/ templated string/ string interpolation
        //    //C# 6.0 - .Net Frameowrk 4.6
        //    string info = base.GetInformation();
        //    return $"{info}";
        //}
    }
}
