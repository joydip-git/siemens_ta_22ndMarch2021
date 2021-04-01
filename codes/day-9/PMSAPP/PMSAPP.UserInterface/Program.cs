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
        }
    }
}
