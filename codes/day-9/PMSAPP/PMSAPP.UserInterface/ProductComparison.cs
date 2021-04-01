using PMSAPP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSAPP.UserInterface
{
    class ProductComparison : IComparer<Product>
    {
        private int _choice;
        public ProductComparison()
        {

        }
        public ProductComparison(int choice)
        {
            _choice = choice;
        }
        public int Compare(Product x, Product y)
        {
            int res = 0;
            switch (_choice)
            {
                //by name (if name is same then description)
                case 1:
                    res = x.ProductName == y.ProductName ? x.Description.CompareTo(y.Description) : x.ProductName.CompareTo(y.ProductName);
                    break;

                //by price (if price is same then id)
                case 2:
                    res = x.Price == y.Price ? x.ProductId.CompareTo(y.ProductId) : x.Price.CompareTo(y.Price);
                    break;

                //by id
                default:
                    res = x.ProductId.CompareTo(y.ProductId);
                    break;
            }
            return res;
        }
    }
}
