using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;


public partial class Admin_Panel_dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string delid = Request.QueryString["delid"];
        string upid = Request.QueryString["upid"];

        if (delid != null)
        {
            FlightType data = new FlightType(delid);
            data.delete();
        }
        else if (upid != null)
        {
            FlightType data = new FlightType(upid);
            object []record = data.get();

            txtFlightID.Value = record[0] + "";
            txtFlightType.Value = record[1]+"";

            btnSave.Value = "Update";
        }
    }

    protected void btnSave_ServerClick(object sender, EventArgs e)
    {
        FlightType data = new FlightType(int.Parse(txtFlightID.Value), txtFlightType.Value);

        if (btnSave.Value.Equals("Save"))
        {
            data.insert();
        }
        else if (btnSave.Value.Equals("Update"))
        {
            data.update();
        }

        Response.Write("<script>alert(Flight Type Inserted);</script>");
    }

    protected void deleteLinkClick(object sender, EventArgs e)
    {
      //  Response.Write("<script>alert('Clicked');</script>");
 
    }
}