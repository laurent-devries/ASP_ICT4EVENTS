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

        public Locatie()
        {

        }
    }
}