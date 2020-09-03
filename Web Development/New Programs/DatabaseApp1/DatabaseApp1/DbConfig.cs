using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseApp1
{
    public class DbConfig
    {
        string data_source = @"(LocalDB)\v11.0";
        string db_path = @"C:\Students\C#.Net_Batch6\database\Database1.mdf";
        string username = "";
        string password = "";

       
        public SqlConnection connectSqlServer()
        {
            //string conn_string = @data_source + ";AttachDbFilename=" + db_path + ";Integrated Security=True;Connect Timeout=30";
            string conn_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Students\C#.Net_Batch6\database\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(conn_string);
            return conn;
        }

        public void connectMySQL() { }
        public void connectOracle() { }
        public void connectMongoDb() { }
    }
}
