using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace WebApp6DatabaseConnection
{
    public partial class Page3 : System.Web.UI.Page
    {
        public LinkedList<Department> deptList;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowDepartments_Click(object sender, EventArgs e)
        {
            DbHelper db = new DbHelper();
            SqlConnection conn = null;

            try
            {
                conn = db.ConnectSqlServer();
                string query = "SELECT deptid, deptname FROM viewDepartment";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader R = cmd.ExecuteReader();

                deptList = new LinkedList<Department>();

                while(true)
                {
                    if (R.Read() == false)
                        break;

                    deptList.AddLast(new Department((int)R["deptid"], R["deptname"].ToString()));
                    
                }

                
            }
            catch(Exception ex)
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