using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _006_övning2_databas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=localhost:initial Catalog=AdventureWorks2012;User ID=DavidDeveloper; Password=dummypassword;Integrated Security = True");
            string sqlQuery = "SELECT * FROM Production.ProductCategory";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader oreader;
            try
            {
                ListItem newItem = new ListItem();
                newItem.Text = "Select";
                newItem.Value = "0";
                DropDownList1.Items.Add(newItem);
                con.Open();
                oreader = cmd.ExecuteReader();
                while (oreader.Read())
                {
                    ListItem listItem1 = new ListItem();
                    listItem1.Text = oreader["Name"].ToString();
                    listItem1.Value = oreader["ProductCategoryID"].ToString();
                    DropDownList1.Items.Add(listItem1);
                }
                oreader.Close();
                oreader.Dispose();
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
            }

        }
    }
}