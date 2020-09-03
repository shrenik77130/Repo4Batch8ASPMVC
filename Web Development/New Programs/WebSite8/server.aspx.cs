using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class server : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Request.QueryString["name"];

        if (name != null)
        {
            LclientName.Text = Request.QueryString["name"] + " requesting for Client Data";
        }
    }

    protected void btnResponseClient_Click(object sender, EventArgs e)
    {

        ClientData c1 = new ClientData();
        
        /*
        Response.Redirect("client.aspx?data="+c1);
         
         Note : can not sent Custom Class objects in form of query String 
         */

        // OR 
        Session["clientrecords"] = c1;
        Response.Redirect("client.aspx");
    }
}