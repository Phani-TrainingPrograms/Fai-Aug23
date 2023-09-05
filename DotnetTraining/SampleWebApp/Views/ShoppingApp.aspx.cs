using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Views
{
    public partial class ShoppingApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Get the Application object and its data.
                var data = Application["products"] as List<Product>;
                lstProducts.DataSource = data;
                lstProducts.DataTextField = "ProductName";
                lstProducts.DataValueField = "ProductId";
                lstProducts.DataBind();
            }
        }

        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = Application["products"] as List<Product>;
            var selectedId = int.Parse(lstProducts.SelectedValue);
            var selectedProduct = data.Find((p) => p.ProductId == selectedId);
            txtId.Text = selectedProduct.ProductId.ToString();
            txtName.Text = selectedProduct.ProductName;
            txtPrice.Text = selectedProduct.ProductCost.ToString();
            imgProduct.ImageUrl = selectedProduct.Image;

            //Add the selected object into the session queue
            var queue = Session["cart"] as Queue<Product>;
            if (queue.Count == 5)
                queue.Dequeue();
            queue.Enqueue(selectedProduct);
            dlRecent.DataSource = queue.Reverse();
            dlRecent.DataBind();
            Session["cart"] = queue;


        }
    }
}