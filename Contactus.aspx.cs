using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Default4 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=db02;Initial Catalog=EmployeeDB;User ID=prajnan;Password=test,1234");
    static SqlDataReader dr;
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        
        if (Session["x"] != null)
        {
            SqlCommand cmd = new SqlCommand("select Role from userTB where Username='" + Session["x"].ToString() + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            if (dr.GetValue(0).ToString()=="Student")
            {

                Response.Redirect("No_rights.aspx");
            }
            else
            {
                Response.Write("Hello Ladies");
            }
        }
        else
        {
            Response.Redirect("Pl_Login.aspx");        
        }
    }
}