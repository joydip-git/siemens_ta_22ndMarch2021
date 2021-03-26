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

        public void CalculateSalary()
        {
            base.CalculateSalary();
            EmployeeTotalSalary = EmployeeTotalSalary + incentivePayment;
        }
    }
}
