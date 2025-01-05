using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace WebApplication4
{
    public partial class Loginpg : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        string query = "SELECT Count(1) FROM UserData where Email=@Emailid AND pass=@Password";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                string username = email_id.Value;
                string password = pwd.Value;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
               SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Emailid", username);
                cmd.Parameters.AddWithValue("Password", password);   
                int usercount=Convert.ToInt32 (cmd.ExecuteScalar());
                if (usercount > 0)
                {

                    Session["username"] = username;
                    Response.Redirect("DashGopalk.aspx",false);
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}