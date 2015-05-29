using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class ReserveringManager
    {
        List<Reservering> reserveringList;
        public ReserveringManager()
        {
            reserveringList = new List<Reservering>();
        }

        public List<Reservering> GetReserveringen()
        {
            return reserveringList;
        }

        public bool AddReservering(Reservering reservering)
        {
            return true;
        }

        public bool DeleteReservering(Reservering reservering)
        {
            return true;
        }
    }
}