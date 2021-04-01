namespace PMSAPP.Entities
{
    public class Product
    {
        //Backing field
        // private readonly int productId;
        //public int ProductId { get => productId; }
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {

        }
        //public Product(int productId)
        //{
        //    this.productId = productId;
        //}
        public Product(int id, string name, decimal price, string description) //: this(id)
        {
            ProductName = name;
            Price = price;
            Description = description;
        }
        public override string ToString()
        {
            return $"Id:{ProductId}, Name:{ProductName}, Price:{Price}, Description:{Description}";
        }
    }
}
