using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class DashGopalk : System.Web.UI.Page
    {
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
    }
}