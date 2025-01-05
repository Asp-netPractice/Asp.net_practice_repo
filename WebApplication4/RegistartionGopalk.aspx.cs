using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;


namespace WebApplication4
{
    public partial class RegistartionGopalk : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        string query = "INSERT INTO UserData ( F_name,L_name,Email, pass) VALUES (@Frst_name,@Last_name,@Emailid,@Password)";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                string First_name = Text3.Value;

                string Lastname = Text1.Value;
                string password = pass.Value;
                string Emailid = email_id.Value;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Frst_name", First_name);
                command.Parameters.AddWithValue("@Last_name", Lastname);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Emailid", Emailid);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User inserted successfully!");
                    Response.Redirect("Loginpg.aspx", false);
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
