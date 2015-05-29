using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Polsbandje
    {
        public int Id_Polsbandje { get; set; }
        public string Barcode { get; set; }
        public bool Actief { get; set; }

        public Polsbandje(int id_Polsbandje, string barcode)
        {
            Id_Polsbandje = id_Polsbandje;
            Barcode = barcode;
            Actief = false;
        }
    }
}