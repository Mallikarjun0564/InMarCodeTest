using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
            ProductName = "";
            Price = 0;
            Description = "";
        }
    }
}
