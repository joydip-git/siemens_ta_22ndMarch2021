namespace OutstandingPersonApp
{
    class Author : Person
    {
        int numberOfBooksPublished;

        public Author()
        {

        }

        public Author(string name, int numberOfBooksPublished) : base(name)
        {
            //this.name = name;
            this.numberOfBooksPublished = numberOfBooksPublished;
        }

        public int NumberOfBooksPublished
        {
            get => numberOfBooksPublished;
            set => numberOfBooksPublished = value;
        }

        public override bool IsOutstanding()
        {
            return this.numberOfBooksPublished > 10 ? true : false;
        }

        public string Show()
        {
            return $"Name: {this.Name}, Books Published:{numberOfBooksPublished}";
        }
    }
}
