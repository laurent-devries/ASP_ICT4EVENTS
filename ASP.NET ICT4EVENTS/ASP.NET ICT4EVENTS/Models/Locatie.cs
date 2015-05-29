using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Locatie
    {
        public int Id_Locatie { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public int Nr { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }

        public Locatie(int id_Locatie, string naam, string straat, int nr, string postcode, string plaats)
        {
            Id_Locatie = id_Locatie;
            Naam = naam;
            Straat = straat;
            Nr = nr;
            Postcode = postcode;
            Plaats = plaats;
        }
    }
}