using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Demo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    int i = 0;
    string name = null;
    
    string[] arr = new string[100];
    public void Button1_Click1(object sender, EventArgs e)
    {
        Label2.Text = null;
        foreach (GridViewRow gvr in GridView1.Rows)
        {


            if (((CheckBox)gvr.FindControl("CheckBox1")).Checked == true)
            {
                 name= gvr.Cells[1].Text;
                 arr[i] = name;
                 i++;


            }
        }
        for (int j = 0; j <= 10; j++)
        {

            Label2.Text += "     "+ arr[j];        
        }
       
    }

  
    }
