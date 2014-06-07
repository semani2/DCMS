using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

public partial class Stu_loginaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["x"] != null)
        {
            Response.Redirect("Y_login.aspx");

        }
       
    }
    
     
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr;
    SqlCommand cmd;
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        cmd = new SqlCommand("select Password from studemoTB where Username='"+TextBox1.Text+"'", conn);
        
        dr = cmd.ExecuteReader();
        
        if (dr.Read())
        {
            if (dr.GetValue(0).ToString() == TextBox2.Text)
            {
                dr.Close();


                Session["x"] = TextBox1.Text;

                Session.Timeout = 10;
                Response.Redirect("Home.aspx");


            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Login unsuccesful please try again";

            }

        }
        else
        {

            Label2.Visible = true;
            
            Label2.Text = "Login unsuccesful please try again";
        
        
        }

                
        }

   
}