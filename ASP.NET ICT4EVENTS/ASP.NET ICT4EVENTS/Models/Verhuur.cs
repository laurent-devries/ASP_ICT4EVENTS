﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Verhuur
    {
        public int Id_Verhuur { get; set; }
        public DateTime DatumIn { get; set; }
        public DateTime DatumUit { get; set; }
        public Decimal Prijs { get; set; }
        public bool Betaald { get; set; }

        public Verhuur(int id_Verhuur, DateTime datumIn, DateTime datumUit, Decimal prijs)
        {
            Id_Verhuur = id_Verhuur;
            DatumIn = datumIn;
            DatumUit = datumUit;
            Prijs = prijs;
            Betaald = false;
        }
    }
}