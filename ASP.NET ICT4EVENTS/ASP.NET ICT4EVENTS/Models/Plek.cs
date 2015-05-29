using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Plek
    {
        public int Id_Plek { get; set; }
        public int Nummer { get; set; }
        public int Capaciteit { get; set; }
        public int Waarde { get; set; }

        public Plek(int id_Plek, int nummer, int capaciteit, int waarde)
        {
            Id_Plek = id_Plek;
            Nummer = nummer;
            Capaciteit = capaciteit;
            Waarde = waarde;
        }
    }
}