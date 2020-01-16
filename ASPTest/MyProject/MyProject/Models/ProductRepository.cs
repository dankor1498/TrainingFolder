using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class ProductRepository
    {
        private List<Product> products;
        
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product{ Name = "BMW", Price = 850M },
                new Product{ Name = "Toyota", Price = 350M },
                new Product{ Name = "Audi", Price = 300M },
                new Product{ Name = "Land Rover", Price = 950M },
                new Product{ Name = "Lada", Price = 600M }
            };
        }

        public IEnumerable<Product> GetProducts => products;
    }
}
