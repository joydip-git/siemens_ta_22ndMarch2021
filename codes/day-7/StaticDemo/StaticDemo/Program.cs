using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Employee
    {
        //static or shared data member
        readonly int a;
        static readonly decimal bonusPayment = 1000;
        const int X = 10; //const data member(s) is/are by default static

        //instance data members
        decimal basicPayment;
        decimal daPayment;
        decimal hraPayment;
        protected decimal totalSalary;

        public static void Foo() { }

        static Employee()
        {
            bonusPayment = 1000;
        }

        public Employee()
        {

        }
        public Employee(decimal basic, decimal da, decimal hra)
        {
            //bonusPayment = bonus;
            basicPayment = basic;
            daPayment = da;
            hraPayment = hra;
        }

        //instance property
        public decimal TotalSalary { get => totalSalary; }

        //static property
        public static decimal BonusPayment { get => bonusPayment; }//set => bonusPayment = value; }

        //static method
        //public static decimal GetBonusPayment()
        //{
        //    return bonusPayment;
        //}
        //public static void SetBonusPayment(decimal bonus)
        //{
        //    basicPayment < -- static members can't access non-static members
        //    bonusPayment = bonus;
        //}

        //instance or non-static method
        public virtual void CalculateSalary()
        {
            //bonusPayment = 2000;
            //but non-static members can access statis members
            totalSalary = bonusPayment + this.basicPayment + this.daPayment + this.hraPayment;
        }
    }
    class Developer : Employee
    {
        decimal incentivePayment;
        public Developer()
        {

        }
        public Developer(decimal basic, decimal da, decimal hra, decimal incentive)
            : base(basic, da, hra)
        {
            incentivePayment = incentive;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            totalSalary += incentivePayment;
        }
    }
    class Hr : Employee
    {
        decimal gratuityPayment;
        public Hr()
        {

        }
        public Hr(decimal basic, decimal da, decimal hra, decimal gratuity)
            : base(basic, da, hra)
        {
            gratuityPayment = gratuity;
        }
        public override void CalculateSalary()
        {
            totalSalary += gratuityPayment;
        }
    }
    class Program
    {
        //compile time polymorphism
        void Add(int a, int b)
        {

        }
        void Add(int a, int b, int c)
        {

        }
        static void Main()
        {
            Program p = new Program();
            p.Add(12, 13);
            //1.
            //Employee.BonusPayment = 1000;
            //Employee.Foo();

            //Employee.SetBonusPayment(1000);
            //Console.WriteLine(Employee.BonusPayment);
            //Console.WriteLine(Employee.GetBonusPayment());

            Developer anilDeveloper = new Developer(basic: 1000, da: 2000, hra: 3000, incentive: 4000);
            anilDeveloper.CalculateSalary();
            Console.WriteLine(anilDeveloper.TotalSalary);
            //Developer sunilDeveloper = new Developer();
            Hr kamakshiHr = new Hr(basic: 1500, da: 2500, hra: 3500, gratuity: 4500);
            //Hr joydipHr = new Hr();

            //Employee.BonusPayment = 2000;
        }
    }
    abstract class Person
    {
        public abstract bool IsOutstanding();
    }
    class Author : Person
    {
        public override bool IsOutstanding() { return false; }
    }
}
