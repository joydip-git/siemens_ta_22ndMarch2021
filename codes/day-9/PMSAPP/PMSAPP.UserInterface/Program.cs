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
            var products = new List<Product>
            {
                new Product { ProductId = 2, ProductName = "Dell XPS", Price = 167000, Description = "new version of laptop from dell" },
                new Product { ProductId = 1, ProductName = "HP Probook", Price = 145000, Description = "new version of laptop from HP" },
                new Product { ProductId = 3, ProductName = "Lenovo Beast", Price = 135000, Description = "new version of laptop from Lenovo" }
            };
            //for (int i = 0; i < products.Count; i++)
            //{
            //    for (int j = i + 1; j < products.Count; j++)
            //    {
            //        if (products[i].CompareTo(products[j]) > 0)
            //        {
            //            Product temp = products[i];
            //            products[i] = products[j];
            //            products[j] = temp;
            //        }
            //    }
            //}
            //products.Sort();

            PrintSortChoice();
            int choice = GetChoice();

            ProductComparison productComparison = new ProductComparison(choice);
            //for (int i = 0; i < products.Count; i++)
            //{
            //    for (int j = i + 1; j < products.Count; j++)
            //    {
            //      //if (products[i].CompareTo(products[j]) > 0)
            //        if (productComparison.Compare(products[i], products[j]) > 0)
            //        {
            //            Product temp = products[i];
            //            products[i] = products[j];
            //            products[j] = temp;
            //        }
            //    }
            //}
            products.Sort(productComparison);
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
    }
}
