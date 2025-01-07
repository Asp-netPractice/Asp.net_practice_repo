using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication4
{
    public partial class DashGopalk : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        string query = "INSERT INTO StudentData (S_name, roll_no, marks,topic) VALUES (@stdname, @rollno, @mrks,@subject)";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Loginpg.aspx");
            }
            else
            {
                litUsername.Text = Session["Username"].ToString();
            }

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Loginpg.aspx");
        }
        protected void insrt_btn(object sender, EventArgs e)
        {
            try
            {
                string studentname = stdname.Value;
                string rollnumber = rollno.Value;
                string marksinsbjt =marks.Value;
                string subjt=subject.Value;
                SqlConnection connction = new SqlConnection(connectionString);
                if (connction.State == System.Data.ConnectionState.Open)
                {
                    connction.Close();
                }
                else {
                    connction.Open();
                    SqlCommand Command = new SqlCommand(query, connction);
                    Command.Parameters.AddWithValue("@stdname", studentname);
                    Command.Parameters.AddWithValue("@rollno", rollnumber);
                    Command.Parameters.AddWithValue("@mrks", marksinsbjt);
                    Command.Parameters.AddWithValue("@subject", subjt);

                    int RowsrowsAffected = Command.ExecuteNonQuery();
                    if (RowsrowsAffected > 0)
                    {
                        MessageBox.Show(" Data entered succesfully");
                    }
                    else {
                        MessageBox.Show("no row affected");
                    
                    }

                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void dlt_btn(object sender, EventArgs e)
        {

        }
        protected void updt_btn(object sender, EventArgs e)
        {

        }
    }
}