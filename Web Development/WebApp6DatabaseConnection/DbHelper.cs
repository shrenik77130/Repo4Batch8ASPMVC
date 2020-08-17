using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApp6DatabaseConnection
{
    
    public class DbHelper
    {
        public SqlConnection conn;

        public DbHelper() { }

        public SqlConnection ConnectSqlServer()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ASP\Web Development\WebApp6DatabaseConnection\App_Data\restaurant.mdf;Integrated Security=True;Connect Timeout=30");

            return conn;
        }
    }
}