using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication4
{
    public partial class NayanGrideView2 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnectionNayan"].ConnectionString;
        string query = "select * from User_Table";
        protected void Page_Load(object sender, EventArgs e)
        {
            GrideBind();

        }

        private void GrideBind()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();    
                adapter.Fill(dataSet);

                if (dataSet.Tables.Count > 0)
                {
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                            GridView1.DataSource = dataSet.Tables[0];
                            GridView1.DataBind();

                            GridView2.DataSource = dataSet.Tables[0];
                            GridView2.DataBind();
                    }


                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


    }
}