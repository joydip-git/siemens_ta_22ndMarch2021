using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Trainee //base/parent class
    {
        protected string name;
        public const string ADHAAR_NUMBER = "";
        public Trainee()
        {

        }
        public Trainee(string name)
        {
            this.name = name;
        }
        public string Name { set => name = value; get => name; }
        public string PrintInfo()
        {
            return null;
        }
    }
    class AutoamtionTestingTrainee : Trainee //child/derived class
    {
        string x;
        public AutoamtionTestingTrainee()
        {

        }
        public AutoamtionTestingTrainee(string name, string x)
        {
            this.x = x;
            this.name = name;
            //this.Name = name;
        }
    }
    public sealed class SeleniumTrainee : AutoamtionTestingTrainee
    {

    }
    class SomeTrainee { }//: SeleniumTrainee { }
    class OtherTrinee : Trainee //child/derived class
    {
        string y;
        public OtherTrinee()
        {
            this.name = "";
        }
    }
    class Program
    {
        static void Main()
        {
            AutoamtionTestingTrainee seleniumTrainee = new AutoamtionTestingTrainee();
            seleniumTrainee.Name = "";
            //Math.PI
        }
    }
}
