using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NET_ICT4EVENTS.Images;

namespace ASP.NET_ICT4EVENTS
{
    public partial class MediaFeed : System.Web.UI.Page
    {
        Image[] imageArray = new Image[3];
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Adding the objects to the arrays
            imageArray[0] = Image1;
            imageArray[1] = Image2;
            imageArray[2] = Image3;
            #endregion
        }

        protected void resizeAndAddImages()
        {
            for (int i = 0; i < imageArray.Length; i++)
            {
                imageArray[i].ImageUrl = "~/Images/SjonhetSchaap.jpg";
                imageArray[i].Width = 150;
            }
        }

        protected Image GetImage()
        {
            Image schaap = new Image();
            schaap.ImageUrl = "C:/Users/frank/Pictures/SjonhetSchaap";
            return schaap;
        }
    }
}