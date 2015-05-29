using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_ICT4EVENTS.Models
{
    public class EventManager
    {
        List<Event> eventList;
        public EventManager()
        {
            eventList = new List<Event>();
        }

        public List<Event> GetEvents()
        {
            return eventList;
        }

        public bool addEvent(Event evenement)
        {
            return true;
        }

        public bool deleteEvent(Event evenement)
        {
            return true;
        }
    }
}