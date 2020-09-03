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
        Response.Write("<br>Page Load Event Called");
        Response.Write("<br>Is Postack = " + IsPostBack);

        if (IsPostBack == false)
        {
            ViewState["cnt"] = 0;
        }
        else
        {
            Response.Write("<br>Page Postback Count = " + ViewState["cnt"]);
        }
    }

    protected void countPostBack(object sender, EventArgs e)
    {
        int c = (int)ViewState["cnt"];
        c++;
        ViewState["cnt"] = c;
    }
}