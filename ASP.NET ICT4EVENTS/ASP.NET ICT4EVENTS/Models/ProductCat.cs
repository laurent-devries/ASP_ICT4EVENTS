using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class ProductCat
    {
        public int Id_ProductCat { get; set; }
        public int Id_CatParent { get; set; }
        public string Name { get; set; }

        public ProductCat()
        {

        }
    }
}