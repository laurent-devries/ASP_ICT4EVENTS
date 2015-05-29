using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Bijdrage
    {
        public int Id_Bijdrage { get; set; }
        public DateTime Datum { get; set; }
        public string Naam { get; set; }

        public Bijdrage(int id_Bijdrage, DateTime datum, string naam)
        {
            Id_Bijdrage = id_Bijdrage;
            Datum = datum;
            Naam = naam;
        }
    }
}