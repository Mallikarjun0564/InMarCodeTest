using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers
{
    public class OfferService
    {
        private List<Product> Inventory = null;

        public OfferService()
        {
            Inventory = new List<Product>();
        }

        private List<Product> AddInventory()
        {
            Product objProduct1 = new Product();
            objProduct1.ProductName = "p1";
            objProduct1.Price = 1000;
            objProduct1.Description = "p1 desc";
            Inventory.Add(objProduct1);
            Product objProduct2 = new Product();
            objProduct2.ProductName = "p2";
            objProduct2.Price = 200;
            objProduct2.Description = "p2 desc";
            Inventory.Add(objProduct2);
            Product objProduct3 = new Product();
            objProduct3.ProductName = "p3";
            objProduct3.Price = 400;
            objProduct3.Description = "p3 desc";
            Inventory.Add(objProduct3);
            Product objProduct4 = new Product();
            objProduct4.ProductName = "p4";
            objProduct4.Price = 600;
            objProduct4.Description = "p4 desc";
            Inventory.Add(objProduct4);
            Product objProduct5 = new Product();
            objProduct5.ProductName = "p5";
            objProduct5.Price = 700;
            objProduct5.Description = "p5 desc";
            Inventory.Add(objProduct5);
            Product objProduct6 = new Product();
            objProduct6.ProductName = "p6";
            objProduct6.Price = 800;
            objProduct6.Description = "p6 desc";
            Inventory.Add(objProduct6);

            return Inventory;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> lst = new List<Product>();
            lst = AddInventory();
            return lst;
        }

        public void AddProduct( string productName,string productDes,decimal price)
        {
            Product obj = new Product();
            obj.Price = price;
            obj.Description = productDes;
            obj.ProductName = productName;
        }

    }
}
