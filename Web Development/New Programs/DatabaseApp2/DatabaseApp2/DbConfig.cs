using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseApp2
{
    public class DbConfig
    {
        public SqlConnection connectSQLServerDb()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Students\C#.Net_Batch6\DatabaseApp2\DatabaseApp2\vehicledb.mdf;Integrated Security=True";

            return conn;
        }

        public static SqlConnection connect()
        {
            DbConfig dbobj = new DbConfig();
            return dbobj.connectSQLServerDb();
        }
    }
}
