using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Persoon
    {
        public int Id_Persoon { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public string Straat { get; set; }
        public int Huisnr { get; set; }
        public string Woonplaats { get; set; }
        public string BankNr { get; set; }

        public Persoon()
        {

        }
    }
}