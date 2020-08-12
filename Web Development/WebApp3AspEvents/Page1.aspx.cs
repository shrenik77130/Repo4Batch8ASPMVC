using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp3AspEvents
{
    public partial class Page1 : System.Web.UI.Page
    {
        //one time use
        public string username;

        protected void Page_Load(object sender, EventArgs e)
        {
            // if block of code only run for first time when project starts
            Response.Write("<br>State = " + IsPostBack);

            if (IsPostBack == false)
            {
                this.username = "Shrenik";
              //  ViewState["username"] = this.username;
            }
                

            
            Response.Write("<br>variable username = " + this.username);
            Response.Write("<br>view state username = " + ViewState["username"]);
        }

        protected void btnUsername_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hello "+this.username+"');</script>");
        }

        protected void btnChangeUsername_Click(object sender, EventArgs e)
        {
            // this.username = txtNewUsername.Text; won't work

            ViewState["username"] = txtNewUsername.Text;
            Response.Write("<br>After form Submit username = " + ViewState["username"]);
        }
    }
}