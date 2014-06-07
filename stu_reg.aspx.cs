using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

public partial class stu_reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr;
    SqlCommand cmd,cmd1;
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        conn.Open();
        cmd = new SqlCommand("select * from stuDemoTB where Username='"+TextBox2.Text+"'", conn);
        dr = cmd.ExecuteReader();
        
        if (dr.Read())
        {
            Label2.Visible = true;
            Label2.Text = "Username not available";
        }
        else
        {
            Label2.Visible = true;
        Label2.Text = " available";
    }
       
    }
    string name;
   
   
        
            protected void Button1_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("Pics/");
        if (FileUpload1.HasFile)
        {
            string ext = Path.GetExtension(FileUpload1.FileName);
            if (ext == ".jpg" || ext == ".png")
            {
                FileUpload1.SaveAs(path + FileUpload1.FileName);
                name = "~/Pics/" + FileUpload1.FileName;
            }
        }
        SqlCommand cmd = new SqlCommand("Insert Into studemoTB(Username,Name,Password,College,EmailID,SecurityQuestion,SecurityAnswer,Role,Image) values(@Username,@Name,@Password,@College,@EmailID,@SecurityQuestion,@SecurityAnswer,@Role,'"+name+"')", conn);
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Username", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
        cmd.Parameters.AddWithValue("@College", TextBox5.Text);
        cmd.Parameters.AddWithValue("@EmailID", TextBox6.Text);
        cmd.Parameters.AddWithValue("@SecurityQuestion", TextBox7.Text);
        cmd.Parameters.AddWithValue("@SecurityAnswer", TextBox8.Text);
        cmd.Parameters.AddWithValue("@Role", "Student");
        SqlCommand cmd1 = new SqlCommand("Insert into userTB(Username,Role) values(@Username,@Role)", conn);
        cmd1.CommandType = System.Data.CommandType.Text;
        cmd1.Parameters.AddWithValue("@Username", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@Role","Student");
                conn.Open();
        cmd.ExecuteNonQuery();
        cmd1.ExecuteNonQuery();
        Response.Redirect("Stu_login.aspx");
    }
}