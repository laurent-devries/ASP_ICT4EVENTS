using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Product
    {
        public int Id_Product { get; set; }
        public string Merk { get; set; }
        public string Serie { get; set; }
        public int Typenummer{get; set;}
        public Decimal Prijs { get; set; }

        public Product(int id_Product, string merk, string serie, int typenummer, Decimal prijs)
        {
            Id_Product = id_Product;
            Merk = merk;
            Serie = serie;
            Typenummer = typenummer;
            Prijs = prijs;
        }



    }
}