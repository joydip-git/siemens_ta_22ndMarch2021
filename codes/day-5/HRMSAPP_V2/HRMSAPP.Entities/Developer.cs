using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSAPP.Entities
{
    public class Developer : Employee
    {
        decimal incentivePayment;
        public Developer()
        {

        }
        public Developer(int id, string name = null, string projectName = null, decimal basicPayment = 0, decimal daPayemnt = 0, decimal hraPayment = 0, decimal incentivePayment = 0)
            : base(employeeId: id, employeeName: name, employeeProjectName: projectName, employeeHraPayment: hraPayment, employeeDaPayemnt: daPayemnt, employeeBasicPayment: basicPayment)
        {
            this.incentivePayment = incentivePayment;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            EmployeeTotalSalary = EmployeeTotalSalary + incentivePayment;
        }
        /**
         *  public virtual string GetInformation()
        {
            //string template/ templated string/ string interpolation
            //C# 6.0 - .Net Frameowrk 4.6
            return $"Name:{this.employeeName}, Id: {employeeId}, Project: {employeeProjectName}, Salary:{employeeTotalSalary}";
        }
         */
    }
}
