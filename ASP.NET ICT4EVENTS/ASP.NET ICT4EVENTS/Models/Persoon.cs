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

        public Persoon(int id_Persoon, string voornaam, string tussenvoegsel, string achternaam, string straat, int huisnr, string woonplaats, string bankNr)
        {
            Id_Persoon = id_Persoon;
            Voornaam = voornaam;
            Tussenvoegsel = tussenvoegsel;
            Achternaam = achternaam;
            Straat = straat;
            Huisnr = huisnr;
            Woonplaats = woonplaats;
            BankNr = bankNr;
        }
    }
}