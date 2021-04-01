using System;

namespace PMSAPP.Entities
{
    public class Product : IComparable<Product>
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

        public override int GetHashCode()
        {
            int hash = this.ProductId.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            Product other = obj as Product;
            if(this == other)
            {
                return true;
            }

            if (!this.ProductId.Equals(other.ProductId))
                return false;

            if (!this.ProductName.Equals(other.ProductName))
                return false;

            if (!this.Price.Equals(other.Price))
                return false;

            if (!this.Description.Equals(other.Description))
                return false;

            return true;
        }

        //public int CompareTo(object obj)
        //{
        //      Product other = obj as Product;
        //      return 0;
        //}

        public int CompareTo(Product other)
        {
            //return <0;
            //return >0;
            //return 0;
            /*
            if (this.ProductId == other.ProductId)
            {
                if (this.ProductName == other.ProductName)
                {
                    if (this.Price == other.Price)
                    {
                        return this.Description.CompareTo(other.Description);
                    }
                    else
                        return this.Price.CompareTo(other.Price);
                }
                else
                    return this.ProductName.CompareTo(other.ProductName);
            }
            else
                return this.ProductId.CompareTo(other.ProductId);
            */
            return this.ProductId.CompareTo(other.ProductId);
        }       
    }
}
