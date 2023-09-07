using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class Caching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLocalTime.Text = DateTime.Now.ToLongTimeString();
            if (Request.QueryString.Count != 0)
            {
                string time = string.Empty;
                var city = Request.QueryString["city"];
                switch (city.ToLower())
                {
                    case "new delhi": time = DateTime.Now.ToString("hh:mm:ss"); break;
                    case "new york": time = DateTime.Now.AddHours(-9.5).ToString("hh:mm:ss"); break;
                    case "canbera": time = DateTime.Now.AddHours(4.5).ToString("hh:mm:ss"); break;
                    case "tokyo": time = DateTime.Now.AddHours(3.5).ToString("hh:mm:ss"); break;
                    case "london": time = DateTime.Now.AddHours(-4.5).ToString("hh:mm:ss"); break;
                    default:
                        time = DateTime.Now.ToString("hh:mm:ss");
                        break;
                }
                lblTime.Text = $"The Time in {city} is {time}";
            }
        }
        protected void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Caching.aspx?city=" + lstCities.Text);
        }
    }
}