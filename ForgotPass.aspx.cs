using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class ForgotPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr,dr1;
    SqlCommand cmd,cmd1;
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        cmd = new SqlCommand("select SecurityAnswer from studemoTB where Username='"+TextBox2.Text+"' and SecurityQuestion='"+DropDownList1.SelectedValue+"'", conn);
        dr = cmd.ExecuteReader();
        dr.Read();
        if (dr.GetValue(0).Equals(TextBox1.Text))
        {
            dr.Close();
            cmd1 = new SqlCommand("select Password from studemoTB where Username='" + TextBox2.Text + "'", conn);
            dr1 = cmd1.ExecuteReader();
            dr1.Read();
            Label2.Visible = true;
            Label2.Text = " Your Password is "+ dr1.GetValue(0).ToString();
            dr1.Close();
            HyperLink8.Visible = true;

        }
        else
        {
            dr.Close(); 
            Label2.Visible = true;
            Label2.Text = "Wrong answer please retry !";
            HyperLink8.Visible = true;
        }
    }
}