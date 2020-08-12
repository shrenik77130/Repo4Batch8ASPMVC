using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp4LoginApplication
{
    public partial class index : System.Web.UI.Page
    {
        public string user="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["log"]!=null)
            {
                //get Session
                LoginLog log = (LoginLog)Session["log"];
                user = log.username;
            }
            else
            {
                Response.Redirect("Page1.aspx");
            }
        }
    }
}