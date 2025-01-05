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
    public partial class RegisterpgNayan : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnectionNayan"].ConnectionString;
        string query = "INSERT INTO User_Table (usrname, pass, email) VALUES (@Username, @Password, @Email)";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_btn(object sender, EventArgs e)
        {
            try
            {   string username = user_name.Value;
                string password = pwd.Value;
                string email = email_id.Value;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User inserted successfully!");
                    Response.Redirect("LoginNayan.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
    }
}