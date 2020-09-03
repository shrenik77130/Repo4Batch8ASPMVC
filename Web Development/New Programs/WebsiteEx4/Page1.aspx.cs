using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void buttonLogin_Click(object sender, EventArgs e)
    {
        string unm = username.Text;
        string pwd = password.Text;

        if (unm.Equals("admin") && pwd.Equals("123456"))
        {
            Response.Write("Login Successfull");
        }
        else 
        {
            Response.Write("Invalid Username Or Password");
        }

    }
}