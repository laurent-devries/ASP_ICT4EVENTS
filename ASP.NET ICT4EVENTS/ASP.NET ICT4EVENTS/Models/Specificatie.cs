using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Specificatie
    {
        public int Id_Specificatie { get; set; }
        public string Naam { get; set; }

        public Specificatie(int id_Specificatie, string naam)
        {
            Id_Specificatie = id_Specificatie;
            Naam = naam;
        }
    }
}