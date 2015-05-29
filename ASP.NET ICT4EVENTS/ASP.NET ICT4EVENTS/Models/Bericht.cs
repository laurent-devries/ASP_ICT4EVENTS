using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Bericht : Bijdrage
    {
        public string Inhoud { get; set; }

        public Bericht(int id_Bijdrage, DateTime datum, string naam, string inhoud)
            : base(id_Bijdrage, datum, naam)
        {
            Inhoud = inhoud;
        }
    }
}