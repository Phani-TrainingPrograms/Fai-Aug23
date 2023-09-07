using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp.Controls
{
    public partial class DataCaching : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Cache["data"] == null)
            {
                var data = GetAllRecords();
                //Cache["data"] = data;
                Cache.Insert("data", data, new System.Web.Caching.CacheDependency(Server.MapPath("~/MyFile.txt")), System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration);
            }
            rpData.DataSource = Cache["data"] as DataTable;
            rpData.DataBind();
        }

        private DataTable GetAllRecords()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FaiTrainingConnectionString1"].ConnectionString;
            string query = "SELECT * FROM PRODUCT";
            var adapter = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet("Data");
            adapter.Fill(ds, "ProductTable");
            return ds.Tables["ProductTable"];
        }
    }
}
//toDo: develop a Book inventory Software that stores the books and author details of the book in the database. use the disconnected architecture to get info about the books and authors. The App should have search feature of both by title and author. An Author can write many books. So when a book is added to the database, the Author info will also be updated, if the Author already exists in the database, it should not update it again, else if the Author does not exist, then the App should add the author along with the new book.  The App should use Repeater to display the Search results in the Application. The App should have all the crud operations ready. Provide the scenario of even uploading the image of the book to the database. Images are to be stored in the Images directory of the server with the name of the book as the Image fileName. 