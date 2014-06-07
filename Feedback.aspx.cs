using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;

    }
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Insert Into FeedbackTB(CollegeName,Name,Role,EmailID,Query,isViewed) values(@College_Name,@name,@role,@emailID,@query,@isViewed)", conn);
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Parameters.AddWithValue("@College_Name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@name", TextBox5.Text);
        cmd.Parameters.AddWithValue("@role", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@emailID", TextBox3.Text);
        cmd.Parameters.AddWithValue("@query", TextBox4.Text);
        cmd.Parameters.AddWithValue("@isViewed", "0");
        conn.Open();
        cmd.ExecuteNonQuery();
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        DropDownList1.SelectedValue.FirstOrDefault();
        Label2.Visible = true;
        Label2.Text="Your feedback has been sent";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Label2.Visible = false;

        
    }
}