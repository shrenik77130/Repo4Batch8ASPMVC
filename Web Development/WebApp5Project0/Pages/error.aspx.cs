using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp5Project0
{
    public partial class error : System.Web.UI.Page
    {
        protected string errorMessage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["error"] != null)
            {
                Exception ex = (Exception)Session["error"];
                errorMessage = ex.ToString();
            }
                
        }
    }
}