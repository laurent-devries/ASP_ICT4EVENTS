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

        public ProductCat(int id_productcat, string name)
        {
            Id_ProductCat = id_productcat;
            Name = name;
        }

        public ProductCat(int id_productcat, int id_catParent, string name)
        {
            Id_ProductCat = id_productcat;
            Id_CatParent = id_catParent;
            Name = name;
        }
    }
}