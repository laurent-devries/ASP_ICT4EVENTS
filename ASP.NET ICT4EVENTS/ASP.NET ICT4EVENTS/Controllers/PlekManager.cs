using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class PlekManager
    {
        List<Plek> plekList;
        public PlekManager()
        {
            plekList = new List<Plek>();
        }

        public List<Plek> getPlekken()
        {
            return plekList;
        }

        public bool AddPlek(Plek plek)
        {
            return true;
        }

        public bool DeletePlek(Plek plek)
        {
            return true;
        }
    }
}