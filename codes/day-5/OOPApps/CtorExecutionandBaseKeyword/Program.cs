using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorExecutionandBaseKeyword
{
    class A
    {
        int x;
        int m;
        public A()
        {
            Console.WriteLine("A default ctor");
        }
        public A(int x) //: this()
        {
            Console.WriteLine("A parameterized ctor");
            this.x = x;
        }
        public A(int x, int y) : this(x)
        {
            // this.x = x;
            this.m = y;
        }

        public int X { get => x; set => x = value; }
        public int M { get => m; set => m = value; }

        public virtual string GetInfo()
        {
            return $"X:{x}, M:{m}";
        }
    }
    class B : A
    {
        int y;
        public B()
        {
            Console.WriteLine("B default ctor");
        }
        public B(int a, int b, int c) : base(a, c)
        {
            Console.WriteLine("B parameterized ctor");
            //this.x = a;
            this.y = b;
        }

        public int Y { get => y; set => y = value; }

        //public string GetInfo()
        //{
        //    return $"X:{x}, M:{m}";
        //}
        public override string GetInfo() //+1
        {
            string info = base.GetInfo();
            return $"{info} and Y:{y}";
        }
    }
    class C : A
    {
        int n;
        public C()
        {

        }
        public C(int a, int b, int c) : base(a, b)
        {
            this.n = c;
        }
        public int N { set => n = value; get => n; }
        //public string GetInfo()
        //{
        //    return $"X:{x}, M:{m}";
        //}
        public override string GetInfo()
        {
            return $"{base.GetInfo()},N:{n}";
        }
    }
    class Calculation
    {
        public void Add(int a, int b) { Console.WriteLine(a + b); }
        public void Add(int a, int b, int c) { }
        public void Add(int a, long b, int c) { }
        public void Add(int a, int b, long c) { }
    }
    class Program
    {
        
        static void Print(A obj)
        {
            obj.GetInfo();
            //if(obj is B)
            //{
            //    B b = obj as B;
            //    b.GetValues();
            //}
            //if(obj is C)
            //{
            //    C c = obj as C;
            //    c.Get();
            //}
        }
        static void Main()
        {
            //""+""
            Calculation calculation = new Calculation();
            calculation.Add(12, 13); //caller and called method gets bound during compilation phase
            calculation.Add(12, 13, 14);
            calculation.Add(12, 123456789012, 14);
            calculation.Add(12, 14, 123456789012);
            //upcasting --> implicit conversion
            //A objRef = null;
            //objRef = new A();
            B objBRef = new B(10, 20, 30);
            Print(objBRef);
            C objCRef = new C(40, 50, 60);
            Print(objCRef);
            //string info = objRef.GetValues();
            //Console.WriteLine(info);

            //downcasting-->explicit conversion

            //casting will throw exception
            //B objRef1 = (B)objRef;

            //as operator does not thrown if this downcasting is not possible, simply it will copy the address
            //if (objRef is B)
            //{
            //    //B objRef1 = objRef as B;
            //    B objRef1 = (B)objRef;
            //    objRef1.GetValues();
            //    Console.WriteLine(objRef1);
            //}
            //else
            //    Console.WriteLine("NULL");
            //object a = 10;
            //if(a is int)
            //{

            //}
        }
    }
}
