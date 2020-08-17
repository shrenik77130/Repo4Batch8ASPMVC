using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp6DatabaseConnection
{
    public partial class Page1 : System.Web.UI.Page
    {
        DbHelper db;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDbConnect_Click(object sender, EventArgs e)
        {
            db = new DbHelper();
            try
            {
                conn = db.ConnectSqlServer();

                if (conn == null)
                {
                    Response.Write("<br>Not Able to Connect Database");
                }
                else
                {
                    Response.Write("<br>Connection Successfully Established");
                }
            }
            catch (Exception ex)
            {
                Session["error"] = ex;
                Response.Redirect("ErrorPage.aspx");
            }
            finally
            {
                conn.Close();
            }


        }
    }
}