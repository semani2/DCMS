using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Default5 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr,dr1;
    SqlCommand cmd,cmd1;
    protected void Page_Load(object sender, EventArgs e)
    {
        Image3.Visible = false;
        if (Session["x"] != null)
        {
            Label2.Visible = true;
            Label2.Text = Session["x"].ToString();
            Button1.Visible = true;
            conn.Open();
            cmd1=new SqlCommand("select * from stuDemoTB where Username='" + Session["x"].ToString() + "'", conn);
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cmd = new SqlCommand("select Image from stuDemoTB where Username='" + Session["x"].ToString() + "'", conn);
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    string path = dr1.GetValue(0).ToString();
                    Image3.Visible = true;
                    Image3.ImageUrl = path;
                    dr1.Close();
                }
                else if(dr1.GetValue(0)==null)
                {   

                    Image3.Visible = true;
                    Image3.ImageUrl = "~/images/user.png";
                }
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("select Image from facDemoTB where Username='" + Session["x"].ToString() + "'", conn);
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    string path = dr1.GetValue(0).ToString();
                    Image3.Visible = true;
                    Image3.ImageUrl = path;
                }
                else
                {
                    Image3.Visible = true;
                    Image3.ImageUrl = "~/images/user.png";
                }
            
            
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Remove("x");
        Response.Redirect("Stu_login.aspx");
    }
}