using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace WebApplication4
{
    public partial class LoginNayan : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnectionNayan"].ConnectionString;
        string query = "SELECT COUNT(1) FROM User_Table WHERE usrname = @Username AND pass = @Password";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_btn(object sender, EventArgs e)
        {
            try
            {
                String username = User_name.Value;
                string password = pwd.Value;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int userCount = Convert.ToInt32(command.ExecuteScalar());

                if (userCount > 0)
                {
                    MessageBox.Show("Login successful!");
                    Session["Username"] = username;
                    Response.Redirect("DashboardNayan.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
       
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            
            }

        }
    }
}