using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class RecipiantPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //extractingQueryString();
            //extractingCookies();
            //extractingPreviousPage();
            extractingSessionData();
        }

        private void extractingSessionData()
        {
            var unBoxedData = Session["userDetails"] as UserInfo;
            var name = unBoxedData.UserName;
            var email = string.Empty;
            string display = $"The Name entered is : {name}<br/> The Email Address is {email}";
            lblDisplay.Text = display;
            lblMethod.Text = "Session";
        }

        private void extractingPreviousPage()
        {
            var name = PreviousPage.NameControl.Text;
            var email = PreviousPage.EmailControl.Text;
            string display = $"The Name entered is : {name}<br/> The Email Address is {email}";
            lblDisplay.Text = display;
            lblMethod.Text = "CrossPagePostBack";
        }

        private void extractingCookies()
        {
            if(Request.Cookies["MyCookieInfo"] == null)
            {
                lblDisplay.Text = "No Cookie Info is stored in the browser";
                return;
            }

            var name = Request.Cookies["MyCookieInfo"].Values[0];
            var email = Request.Cookies["MyCookieInfo"].Values[1];
            string display = $"The Name entered is : {name}<br/> The Email Address is {email}";
            lblDisplay.Text = display;
            lblMethod.Text = "Cookies";
        }

        private void extractingQueryString()
        {
            lblMethod.Text = "QueryString";
            if (Request.QueryString.Count == 0)
            {
                lblDisplay.Text = "No Info is shared from the Previous Page, please visit the State Management Page";
                return;
            }
            string actualName = WebUtil.BaseDecrypt(Request.QueryString["name"]);
            string actualEmail = WebUtil.BaseDecrypt(Request.QueryString["email"]);
            string display = $"The Name entered is : {actualName}<br/> The Email Address is {actualEmail}";
            lblDisplay.Text = display;
        }
    }
}