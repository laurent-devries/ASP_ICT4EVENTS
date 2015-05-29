using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class VerhuurManager
    {
        List<Verhuur> VerhuurList;
        public VerhuurManager()
        {
            VerhuurList = new List<Verhuur>();
        }

        public List<Verhuur> GetVerhuren()
        {
            return VerhuurList;
        }

        public bool AddVerhuur(Verhuur verhuur)
        {
            return true;
        }

        public bool DeleteVerhuur(Verhuur verhuur)
        {
            return true;
        }
    }
}