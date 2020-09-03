using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DbConfig
/// </summary>
public class DbConfig
{
	public DbConfig()
	{
		
	}

    public SqlConnection connectSqlServer()
    {
        string connection_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Students\ASP_Batch5\FlightBooking\App_Data\flighDb.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connection_string);

        return conn;
    }

    public static SqlConnection connect()
    {
        DbConfig db = new DbConfig();
        return db.connectSqlServer();
    }
}