using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Bestand : Bericht
    {
        public string Bestandslocatie { get; set; }
        public int Grootte { get; set; }

        public Bestand(int id_Bijdrage, DateTime datum, string naam, string inhoud, string bestandslocatie, int grootte)
            : base(id_Bijdrage, datum, naam, inhoud)
        {
            Bestandslocatie = bestandslocatie;
            Grootte = grootte;
        }
    }
}