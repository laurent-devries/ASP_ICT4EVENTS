using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Reservering
    {
        public int Id_Reservering { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumEinde { get; set; }
        public bool Betaald { get; set; }

        public Reservering()
        {

        }
    }
}