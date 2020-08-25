using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApp6DatabaseConnection
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertQuery_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                DbHelper db = new DbHelper();
                conn = db.ConnectSqlServer();

                conn.Open();
                string query = "INSERT INTO Department(deptid, deptname)VALUES("+txtDeptId.Text+",'" + txtDeptName.Text + "')";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                Response.Write("<br> Department Record Inserted in Database");
                cmd.Parameters.Clear();

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

        protected void btnUsingParameters_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                DbHelper db = new DbHelper();
                conn = db.ConnectSqlServer();

                conn.Open();
                string query = "INSERT INTO Department(deptid, deptname)VALUES(@deptid,@deptname)";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@deptid", int.Parse(txtDeptId.Text));
                cmd.Parameters.AddWithValue("@deptname", txtDeptName.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<br> Department Record Inserted in Database");
                cmd.Parameters.Clear();

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

        protected void btnUsingStoredProcedure_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                DbHelper db = new DbHelper();
                conn = db.ConnectSqlServer();

                conn.Open();
                string query = "spInsertDepartment";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@deptid", int.Parse(txtDeptId.Text));
                cmd.Parameters.AddWithValue("@deptname", txtDeptName.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<br> Department Record Inserted in Database");
                cmd.Parameters.Clear();

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