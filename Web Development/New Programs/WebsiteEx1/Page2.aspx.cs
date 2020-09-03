using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page2 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonclick(object sender, EventArgs e)
    {
        Response.Write("Message is " + txtMessage.Value);
    }
}