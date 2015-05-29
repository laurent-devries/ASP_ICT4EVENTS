using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Event
    {
        public int Id_Event { get; set; }
        public string Naam { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumEinde { get; set; }
        public int MaxBezoekers { get; set; }

        public Event(int id_Event, string naam, DateTime datumstart, DateTime datumeinde, int maxBezoekers)
        {
            Id_Event = id_Event;
            Naam = naam;
            DatumStart = datumstart;
            DatumEinde = datumeinde;
            MaxBezoekers = maxBezoekers;
        }
    }
}