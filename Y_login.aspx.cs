using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Y_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["x"] != null)
        {
            Label2.Visible = true;
            Label2.Text = "You are already logged in " + Session["x"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("x");
        Response.Redirect("Login.aspx");
    }
}