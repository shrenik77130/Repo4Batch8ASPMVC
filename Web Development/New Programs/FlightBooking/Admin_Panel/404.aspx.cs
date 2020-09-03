using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_404 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["error_msg"] != null)
        {
            LerrorMessage.Text = "<i>Due to Connection Issue with Database. Facing following Errors.</i> <br><br>";
            LerrorMessage.Text = LerrorMessage.Text +  Session["error_msg"].ToString();
        }
    }
}