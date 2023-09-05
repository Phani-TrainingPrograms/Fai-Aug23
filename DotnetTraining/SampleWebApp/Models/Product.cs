using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace SampleWebApp.Models
{
    public class Product
    {
        static int no = 0;
        public Product()
        {
            ProductId = ++no;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; } = 100;
    }

    public class ProductManager
    {
        const string STRCONNECTION = @"Data Source=.\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True";
        //Get all the products from the database.
        static SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM PRODUCT", STRCONNECTION);
        static SqlCommandBuilder cb = new SqlCommandBuilder(ada);
        static DataSet ds = new DataSet("TempData");
        public DataTable GetAllProducts()
        {
            ds.Tables.Clear();
            ada.Fill(ds, "RecordOfProducts");
            return ds.Tables[0];
        }

        //using disconnected model to insert the record..
        public void AddNewProduct(Product product)
        {
            if(ds.Tables[0] == null)
            {
                ada.Fill(ds, "RecordOfProducts");
            }
            //create a new blank row with the schema of the Table
            DataRow row = ds.Tables[0].NewRow();
            //Fill the data into the row
            row[1] = product.ProductName;
            row[2] = product.ProductCost;
            row[3] = "Images/"+ product.Image;
            //Add the row into the table of the dataset
            ds.Tables["RecordOfProducts"].Rows.Add(row);
            //Finally update the data to the database...
            ada.Update(ds, "RecordOfProducts");

        }
    }
}