using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image2.Visible = false;
    }
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr,dr1;
    SqlCommand cmd,cmd1;
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string s = "select Name,College,EmailID,Role from stuDemoTB where Username='" + TextBox1.Text + "';";
            conn.Open();
            cmd = new SqlCommand("select Image from stuDemoTB where Username='" + TextBox1.Text + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string path = dr.GetValue(0).ToString();
            Image2.Visible = true;
            Image2.ImageUrl = path;
            dr.Close();
            cmd1 = conn.CreateCommand();
            cmd1.CommandText = s;
            SqlDataAdapter sda = new SqlDataAdapter(cmd1.CommandText, conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            GridView1.DataSource = dtable;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            
        }
        
    }
}