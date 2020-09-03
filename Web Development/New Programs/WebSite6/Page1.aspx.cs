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

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        bool x=false,y=false;

        LoginController LC = new LoginController();
        if (txtUsername.Value.Equals(LC.username))
            x = true;

        if (txtPassword.Value.Equals(LC.password))
            y = true;

        if (x == false)
            Response.Write("<br><b>Invalid Username</b>");
        else if (y == false)
            Response.Write("<br><b>Invalid Password</b>");
        else
        {
            ViewState["username"] = txtUsername.Value;
            //ViewState Store data in the form of Objects
            //ViewState is not for Cross Page Communication

            Session["username"] = txtUsername.Value;
            //Session Stores data in the form of Objects
            //Session State is for Cross Page Communication

            Response.Redirect("Page2.aspx");
        }

        
        }
}