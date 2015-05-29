using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Categorie : Bijdrage
    {
        public Categorie CategorieParent { get; set; }
        public Categorie()
        {

        }
    }
}