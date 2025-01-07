using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows;

namespace WebApplication4
{
    public partial class DashboardNayan : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnectionNayan"].ConnectionString;
        private static string userId = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("LoginNayan.aspx");
            }
            else
            {
                litUsername.Text = Session["Username"].ToString();
                GrideBind();
                updatebtn.Enabled = false;
                deletebtn.Enabled = false;
            }


        }

        public static void UpdateGlobalString(string newValue)
        {
            userId = newValue;
        }

        public static void ClearGlobalString()
        {
            userId = string.Empty;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginNayan.aspx");
        }

        private void GrideBind()
        {
            try
            {
                string query = "select * from Student_table;";
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

                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        protected void Insert_btn(object sender, EventArgs e)
        {
            try
            {
                string username = Username.Value;
                string marks = Marks.Value;
                string sub = Subject.Value;

                string querry = "insert into Student_table (Name, Marks, Subject) values(@name, @marks, @sub)";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(querry, conn);
                conn.Open();
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@marks", Convert.ToInt32(marks));
                command.Parameters.AddWithValue("@sub", sub);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User inserted successfully!");
                    GrideBind();
                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }




            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }


        }

        protected void Update_btn(object sender, EventArgs e)
        {
            try
            {
                
                string username = Username.Value;
                string marks = Marks.Value;
                string sub = Subject.Value;
                string querry = "update Student_table set Name = @name, Marks = @marks,Subject=@subject where Stud_id=@id";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(querry, conn);
                conn.Open();
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@marks", marks);
                command.Parameters.AddWithValue("@subject", sub);
                command.Parameters.AddWithValue("@id", userId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student Updated successfully!");
                    GrideBind();
                    Username.Value = " ";
                    Marks.Value = " ";
                    Subject.Value = " ";
                    inserbtn.Enabled = true;
                    updatebtn.Enabled = false;
                    deletebtn.Enabled = false;
                    ClearGlobalString();

                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        protected void Delete_btn(object sender, EventArgs e)
        {
            try
            {
                string querry = "delete from Student_table where Stud_id = @id";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(querry, conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", userId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student Deleted successfully!");
                    GrideBind();
                    Username.Value = " ";
                    Marks.Value = " ";
                    Subject.Value = " ";
                    inserbtn.Enabled = true;
                    updatebtn.Enabled = false;
                    deletebtn.Enabled = false;
                    ClearGlobalString();

                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow selectedRow = GridView1.SelectedRow;
                if (selectedRow != null) {
                    Literal literalUserId = (Literal)selectedRow.FindControl("LiteralUserId");
                    Literal literalUserName = (Literal)selectedRow.FindControl("LiteralUserName");
                    Literal Literalmarks = (Literal)selectedRow.FindControl("Literalmarks");
                    Literal Literalsub = (Literal)selectedRow.FindControl("Literalsub");
                    UpdateGlobalString(Convert.ToString(literalUserId.Text.Trim()));
                    string name = Convert.ToString(literalUserName.Text.Trim());
                    string marks = Convert.ToString(Literalmarks.Text.Trim());
                    string subject = Convert.ToString(Literalsub.Text.Trim());
                    Username.Value = name;
                    Marks.Value = marks;
                    Subject.Value = subject;
                    inserbtn.Enabled = false;
                    updatebtn.Enabled = true;
                    deletebtn.Enabled = true;



                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}