namespace OutstandingPersonApp
{
    abstract class Person
    {
        protected string name;

        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract bool IsOutstanding();
    }
}
