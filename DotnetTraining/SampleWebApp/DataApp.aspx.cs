using SampleWebApp.Models;
using System;

namespace SampleWebApp
{
    public partial class DataApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var obj = new ProductManager();
                grdProducts.DataSource = obj.GetAllProducts();
                grdProducts.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new ProductManager();
                var product = new Product
                {
                    ProductCost = int.Parse(txtCost.Text),
                    ProductName = txtName.Text,
                    Image = txtImage.Text
                };
                obj.AddNewProduct(product);
                lblStatus.Text = "Product added Successfully";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
    }
}

//toDo: Create Functions in the ProductManager to delete and update and provide the Web Form with features to take input from the user and call the Functions.....
//use bootstrap to divide UR Page and place the Update feature in the Right side..
