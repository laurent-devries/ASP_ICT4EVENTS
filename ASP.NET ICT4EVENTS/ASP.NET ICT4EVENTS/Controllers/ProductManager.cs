using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class ProductManager
    {
        List<Product> productList;
        public ProductManager()
        {
            productList = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            return true;
        }

        public bool DeleteProduct(Product product)
        {
            return true;
        }

        public List<Product> GetProducts()
        {
            return productList;
        }
    }
}