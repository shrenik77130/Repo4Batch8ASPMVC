using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp4LoginApplication
{
    public partial class Page1 : System.Web.UI.Page
    {
        public  bool invalidStatus  = false ;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_click(object sender,EventArgs e)
        {
            string[] user = { "admin", "123456" };

            if(txtUsername.Value.Equals(user[0]) && txtPassword.Value.Equals(user[1]))
            {
                invalidStatus = false;

                //create Session
                LoginLog user1 = new LoginLog(txtUsername.Value,txtPassword.Value);
                Session["log"] = user1;

                Response.Redirect("index.aspx");
            }
            else
            {
                invalidStatus = true;
            }

        }
    }
}