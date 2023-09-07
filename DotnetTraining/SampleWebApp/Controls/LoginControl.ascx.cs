using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Controls
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        public event EventHandler Click;
        public string Title { get; set; } = "Please login";

        public string CreateUserUrl { get; set; }

        public string UserName { get { return this.txtUser.Text; } } 
        public string Password { get { return this.txtPwd.Text; } }

        public string ErrorMessage { 
            get { return lblError.Text; }
            set { lblError.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            hyperLink.NavigateUrl = CreateUserUrl;
            hyperLink.Visible = ShowCreateUser;
            lblError.Visible = true;
            lblError.Text = ErrorMessage;
        }

        public bool ShowCreateUser { get; set; } = false;
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);
        }
    }
}