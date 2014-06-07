using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        TextBox3.Visible = false;
    }

   
   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        TextBox1.Visible = true;
        if (TextBox2.Visible == true)
            TextBox2.Visible = false;
        if (TextBox3.Visible == true)
            TextBox3.Visible = false;

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        TextBox2.Visible = true;
        if (TextBox1.Visible == true)
            TextBox1.Visible = false;
        if (TextBox3.Visible == true)
            TextBox3.Visible = false;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        TextBox3.Visible = true;
        if (TextBox1.Visible == true)
            TextBox1.Visible = false;
        if (TextBox2.Visible == true)
            TextBox2.Visible = false;
    }
}