using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Summary description for FlightType
/// </summary>
public class FlightType : System.Web.UI.Page
{
    public int flighttypeid;
    public string flighttype;

    public FlightType()
    { }

    public FlightType(string id)
    {
        this.flighttypeid = int.Parse(id);
    }

    public FlightType(int id, string flighttype)
    {
        this.flighttypeid = id;
        this.flighttype = flighttype;
    }

    public ArrayList showFlightType()
    {
        ArrayList data = new ArrayList();
        SqlConnection xconn = DbConfig.connect();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = xconn;

        string query = "SELECT flighttypeid,flighttype FROM viewFlightType";
        cmd.CommandText = query;

        try
        {
            xconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (true)
            {
                if (dr.Read())
                {
                    data.Add(
                        new FlightType
                            (int.Parse(dr["flighttypeid"].ToString()),
                              dr["flighttype"].ToString())
                        );
                }
                else
                {
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Session["error_msg"] = ex.ToString();
            HttpContext.Current.Response.Redirect("~/Admin_Panel/404.aspx");
        }
        finally
        {
            cmd.Parameters.Clear();
            xconn.Close();
        }

        return data;

    }

    public object[] get()
    {
        SqlConnection xconn = DbConfig.connect();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = xconn;

        string query = "SELECT flighttypeid,flighttype FROM viewFlightType WHERE flighttypeid = " + flighttypeid;
        cmd.CommandText = query;

        try
        {
            xconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (true)
            {

                if (dr.Read())
                {
                    object[] data = { dr["flighttypeid"].ToString(),
                                      dr["flighttype"].ToString()};
                    return data;
                }
                else
                {
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Session["error_msg"] = ex.ToString();
            HttpContext.Current.Response.Redirect("~/Admin_Panel/404.aspx");
        }
        finally
        {
            cmd.Parameters.Clear();
            xconn.Close();
        }

        return null;

    }
    public void insert()
    {
        SqlConnection xconn = DbConfig.connect();
        SqlCommand cmd = new SqlCommand();

        try
        {

            cmd.Connection = xconn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            string query = "spInsertFightType";
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@flighttype", flighttype);

            xconn.Open();
            cmd.ExecuteNonQuery();


        }
        catch (Exception ex)
        {
            Session["error_msg"] = ex.ToString();
            HttpContext.Current.Response.Redirect("~/Admin_Panel/404.aspx");
        }
        finally
        {
            cmd.Parameters.Clear();
            xconn.Close();
        }
    }

    public void update()
    {
        SqlConnection xconn = DbConfig.connect();
        SqlCommand cmd = new SqlCommand();

        try
        {

            cmd.Connection = xconn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            string query = "spUpdateFightType";
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@flighttypeid", flighttypeid);
            cmd.Parameters.AddWithValue("@flighttype", flighttype);

            xconn.Open();
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Session["error_msg"] = ex.ToString();
            HttpContext.Current.Response.Redirect("~/Admin_Panel/404.aspx");
        }
        finally
        {
            cmd.Parameters.Clear();
            xconn.Close();
        }
    }
    public void delete()
    {
        SqlConnection xconn = DbConfig.connect();
        SqlCommand cmd = new SqlCommand();

        try
        {

            cmd.Connection = xconn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            string query = "spDeleteFlightType";
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@flighttypeid", flighttypeid);

            xconn.Open();
            cmd.ExecuteNonQuery();


        }
        catch (Exception ex)
        {
            Session["error_msg"] = ex.ToString();
            HttpContext.Current.Response.Redirect("~/Admin_Panel/404.aspx");
        }
        finally
        {
            cmd.Parameters.Clear();
            xconn.Close();
        }
    }

}