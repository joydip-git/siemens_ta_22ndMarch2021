namespace HRMSApp
{
    class Employee
    {
        #region Data Members
        int employeeId;
        string employeeName;
        string employeeProjectName;
        decimal employeeBasicPayment;
        decimal employeeDaPayemnt;
        decimal employeeHraPayment;
        decimal employeeTotalSalary;
        #endregion

        #region Constructors
        //ctor code snippet
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
        #endregion

        #region Methods
       
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
        #endregion
    }
}
