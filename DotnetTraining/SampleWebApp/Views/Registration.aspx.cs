using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["FaiTrainingConnectionString1"].ConnectionString))
            {
                string insert = $"Insert into UserTable(UserName, Password) Values('{txtUser.Text}','{txtPwd.Text}')";
                var cmd = new SqlCommand(insert, con);
                con.Open();
                try
                {
                    var rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        Response.Redirect("~/HomePage.aspx");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE"))
                    {
                        lblMessage.Text = "User Name is already taken, Please try another name";
                    }
                }
                con.Close();
            }

        }
    }
}