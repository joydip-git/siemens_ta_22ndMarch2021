namespace OutstandingPersonApp
{
    class Student : Person
    {
        double marks;
        public Student()
        {

        }
        public Student(string name, double marks) : base(name)
        {
            //this.name = name;
            this.marks = marks;
        }

        public double Marks { get => marks; set => marks = value; }

        public override bool IsOutstanding()
        {
            return this.marks > 85;
        }
        public string Print() 
        {
            //return $"Name:{this.Name}, Marks:{marks}";
            return $"Name:{this.name}, Marks:{marks}";
        }
    }
}
