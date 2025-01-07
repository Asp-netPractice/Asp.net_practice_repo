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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = GridView1.SelectedIndex;
            if (selectedindex != -1) {
                string userid = GridView1.SelectedRow.Cells[0].Text;
                string username = GridView1.SelectedRow.Cells[1].Text;
                string useremail = GridView1.SelectedRow.Cells[2].Text;
                MessageBox.Show("" + userid+" "+username+" "+useremail);
            }

                      
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selectedrow = GridView2.SelectedRow;
            //if (selectedindex != -1)
            //{
            //    string userid = GridView2.SelectedRow.Cells[0].Text;
            //    string username = GridView2.SelectedRow.Cells[1].Text;
            //    string useremail = GridView2.SelectedRow.Cells[2].Text;
            //    MessageBox.Show("" + userid + " " + username + " " + useremail);
            //}
            if (selectedrow != null) {
                Literal userid = (Literal)selectedrow.FindControl("LiteralUserId");
                Literal usernameee = (Literal)selectedrow.FindControl("LiteralUsername");
                Literal useremaill = (Literal)selectedrow.FindControl("LiteralUseremail");

                if (userid != null && usernameee != null && useremaill!= null)
                {
                    string useriiid = Convert.ToString(userid.Text.Trim());
                    string username1 = Convert.ToString(usernameee.Text.Trim());
                    string useremail1 = Convert.ToString(useremaill.Text.Trim());
                    MessageBox.Show("" + useriiid + " " + username1 + " " + useremail1);
                }
                
            }
            
        }
    }
}