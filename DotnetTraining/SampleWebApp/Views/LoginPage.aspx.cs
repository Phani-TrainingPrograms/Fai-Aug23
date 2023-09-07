using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using SampleWebApp.Models;

namespace SampleWebApp.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var otp = DbUitl.GenerateOtp();
            int id = DbUitl.ValidateUser(loginCtrl.UserName, loginCtrl.Password, otp);
            Session["UserId"] = id;
            lblOtp.Text = otp;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                throw new Exception("User is not validated yet!!!");
            }
            int id = (int)Session["UserId"];
            if (DbUitl.ValidateOtp(id, txtOtp.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(loginCtrl.UserName, false);
            }
            else
            {
                lblOtp.Text = "Invalid Otp!!!";
            }
        }
    }
}