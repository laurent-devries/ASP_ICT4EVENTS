using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NET_ICT4EVENTS.Models;

namespace ASP.NET_ICT4EVENTS
{
    public partial class MediaFeed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Width = 100;
        }

        protected Image GetImage()
        {
            Image schaap = new Image();
            schaap.ImageUrl = "C:/Users/frank/Pictures/SjonhetSchaap";
            return schaap;
        }
    }
}