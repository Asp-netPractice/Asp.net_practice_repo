using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication4
{

    public partial class GrideviewNayan : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbconnectionNayan"].ConnectionString;
        string query = "select * from User_Table;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrideView();
            }

        }

        private void BindGrideView()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                conn.Close();

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow selectedRow = GridView2.SelectedRow;
                if (selectedRow != null)
                {
                    Literal literalUserId = (Literal)selectedRow.FindControl("LiteralUserId");
                    if (literalUserId != null)
                    {
                        string user_id = literalUserId.Text.Trim();
                        MessageBox.Show(user_id);
                        string querydelete = "  Delete From User_Table where User_id = @User_id;";
                        SqlConnection conn = new SqlConnection(connectionString);
                        conn.Open();
                        SqlCommand command = new SqlCommand(querydelete, conn);
                        command.Parameters.AddWithValue("@User_id", user_id);
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindGrideView();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
