using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class LoginControlExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myLogin.Click += MyLogin_Click;
        }

        private void MyLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var otp = DbUitl.GenerateOtp();
                int id = DbUitl.ValidateUser(myLogin.UserName, myLogin.Password, otp);
                Session["UserId"] = id;
                myLogin.Visible = true;
                myLogin.ErrorMessage = "Validated";
            }
            catch (Exception ex)
            {
                myLogin.Visible = true;
                myLogin.ErrorMessage = ex.Message;
            }
            
        }
    }
}