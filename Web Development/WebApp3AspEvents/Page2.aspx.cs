using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp3AspEvents
{
    public partial class Page2 : System.Web.UI.Page
    {
        public Person p1;

        public bool status;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br> IsPostBack = " + IsPostBack);
            if (IsPostBack == false)
            {
                p1 = new Person();
                ViewState["personObject"] = p1;
            }
            else 
            {
                p1 = (Person)ViewState["personObject"];
            }
                
        }

        protected void btnGetPerson_Click(object sender, EventArgs e)
        {
            Response.Write("<br> <h3>Total Person = " + p1.getListOfPerson().Length + "</h3>");
        }
    }
}