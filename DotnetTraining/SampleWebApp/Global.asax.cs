using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
//A place where we can have App level events and Session level events...
//Start event will be triggered when the first ever request is recieved by the Server. 
namespace SampleWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var data = ProductRepo.AllProducts();
            Application["products"] = data;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            var cart = new Queue<Product>();
            Session["cart"] = cart;
        }
    }
}