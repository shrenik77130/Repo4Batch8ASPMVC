using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2HtmlApproach
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_click(object sender,EventArgs e)
        {
            string empname = txtEmpName.Value;
            Response.Write("Hello " + empname);
        }

        protected void aspBtnSubmit_Click(object sender, EventArgs e)
        {
            string empname = aspTxtEmpName.Text;
            Response.Write("<script>alert('Hello "+ empname + "');</script>");
        }
    }
}