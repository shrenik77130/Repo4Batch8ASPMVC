using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page2 : System.Web.UI.Page
{
    int cnt = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        cnt++;
        Response.Write("Page Loaded for " + cnt + " times");
        Response.Write("Page Status : " + IsPostBack);
    }
}