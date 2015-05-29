using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Categorie : Bijdrage
    {
        public Categorie CategorieParent { get; set; }
        public Categorie(int id_Bijdrage, DateTime datum, string naam)
            : base(id_Bijdrage, datum, naam)
        {

        }

        public Categorie(int id_Bijdrage, DateTime datum, string naam, Categorie categorieParent)
            : base(id_Bijdrage, datum, naam)
        {
            CategorieParent = categorieParent;
        }
    }
}