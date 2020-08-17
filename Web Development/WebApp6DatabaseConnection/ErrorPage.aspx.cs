using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp6DatabaseConnection
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        public string errormsg="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["error"]!=null)
            {
                errormsg = Session["error"].ToString();
            }
        }
    }
}