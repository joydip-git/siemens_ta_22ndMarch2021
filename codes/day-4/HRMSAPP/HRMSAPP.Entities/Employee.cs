namespace HRMSAPP.Entities
{
    public class Employee
    {
        #region Data Members
        readonly int employeeId;
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
        Employee(int id)
        {
            employeeId = id;
        }
        public Employee(int employeeId, string employeeName = null, string employeeProjectName = null, decimal employeeBasicPayment = 0, decimal employeeDaPayemnt = 0, decimal employeeHraPayment = 0)
            : this(employeeId)
        {
            this.employeeName = employeeName;
            this.employeeProjectName = employeeProjectName;
            this.employeeBasicPayment = employeeBasicPayment;
            this.employeeDaPayemnt = employeeDaPayemnt;
            this.employeeHraPayment = employeeHraPayment;
        }
        #endregion

        #region Properties
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeProjectName { get => employeeProjectName; set => employeeProjectName = value; }
        public decimal EmployeeBasicPayment { get => employeeBasicPayment; set => employeeBasicPayment = value; }
        public decimal EmployeeDaPayemnt { get => employeeDaPayemnt; set => employeeDaPayemnt = value; }
        public decimal EmployeeHraPayment { get => employeeHraPayment; set => employeeHraPayment = value; }
        public decimal EmployeeTotalSalary { get => employeeTotalSalary; }

        public int EmployeeId => employeeId;
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
