using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class Productexemplaar
    {
        public int Id_Exemplaar { get; set; }
        public int Volgnummer { get; set; }
        public string Barcode { get; set; }

        public Productexemplaar(int id_Exemplaar, int volgnummer, string barcode)
        {
            Id_Exemplaar = id_Exemplaar;
            Volgnummer = volgnummer;
            Barcode = barcode;
        }
    }
}