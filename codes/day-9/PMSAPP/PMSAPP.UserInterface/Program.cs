using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PMSAPP.Entities;

namespace PMSAPP.UserInterface
{
    class Program
    {
        static void Main()
        {
            var products = CreateList();
            SortProducts(products);
            ShowProducts(products);
        }
        static List<Product> CreateList()
        {
            //return new List<Product>
            //{
            //    new Product { ProductId = 2, ProductName = "Dell XPS", Price = 167000, Description = "new version of laptop from dell" },
            //    new Product { ProductId = 1, ProductName = "HP Probook", Price = 145000, Description = "new version of laptop from HP" },
            //    new Product { ProductId = 3, ProductName = "Lenovo Beast", Price = 135000, Description = "new version of laptop from Lenovo" }
            //};
            HashSet<Product> products = new HashSet<Product>
            {
               new Product { ProductId = 2, ProductName = "Dell XPS", Price = 167000, Description = "new version of laptop from dell" },
               new Product { ProductId = 1, ProductName = "HP Probook", Price = 145000, Description = "new version of laptop from HP" },
               new Product { ProductId = 3, ProductName = "Lenovo Beast", Price = 135000, Description = "new version of laptop from Lenovo" }

            };            
            List<Product> list = products.ToList<Product>();
            return list;
        }
        static void ShowProducts(List<Product> products)
        {
            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }
        }

        private static int GetChoice()
        {
            Console.Write("\nEnter Choice: ");
            return int.Parse(Console.ReadLine());
        }

        private static void PrintSortChoice()
        {
            Console.WriteLine("1. sort by name");
            Console.WriteLine("2. sort by price");
        }
        static void SortProducts(List<Product> products)
        {
            PrintSortChoice();
            int choice = GetChoice();
            ProductComparison productComparison = new ProductComparison(choice);
            products.Sort(productComparison);
        }
    }
}
