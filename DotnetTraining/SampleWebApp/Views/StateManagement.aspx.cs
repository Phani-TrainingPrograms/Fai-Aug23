using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class StateManagement : System.Web.UI.Page
    {
        public TextBox NameControl { get { return txtName; }}
        public TextBox EmailControl { get { return txtEmail; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //queryStringExample();
            //cookiesExample();
            sessionExample();
        }

        private void sessionExample()
        {
            //Session is the part of the Page class. This can be used to store objects in the server. Session stores the data as boxed values. 
            var data = new UserInfo
            {
                UserEmail = txtEmail.Text, UserName = txtName.Text
            };
            Session.Add("userDetails", data);
            Response.Redirect("RecipiantPage.aspx");
                
        }

        private void cookiesExample()
        {
            //Cookies are text based data that can be stored in the client's browser. This is unique to the client Browser. All Cookies are objects of a class called HttpCookie. U should create a cookie object and fill the data and pass it inside the Response object. 
            HttpCookie cookie = new HttpCookie("MyCookieInfo");
            cookie.Values.Add("name", txtName.Text);
            cookie.Values.Add("email", txtEmail.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("RecipiantPage.aspx");
        }

        private void queryStringExample()
        {
            //QueryString is a String based data shared thru' the URL of the Display Page. The data is a key-value pairs each seperated by an &...
            var encryptedName = WebUtil.BaseEncrypt(txtName.Text);
            var encryptedEmail = WebUtil.BaseEncrypt(txtEmail.Text);
            string url = $"RecipiantPage.aspx?name={encryptedName}&email={encryptedEmail}";
            Response.Redirect(url);
        }
    }
}