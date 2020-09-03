using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseApp1
{
    public class Flight
    {
        SqlConnection xconn = null;
        public Flight()
        {
            // creates Database Connection instance
            DbConfig db = new DbConfig();
            xconn = db.connectSqlServer();
        }

        public void saveFlight()
        {
            xconn.Open();
            Console.WriteLine("\n Current Connection Status = " + xconn.State);
            xconn.Close();
        }
        public void updateFlight() { }
        public void deleteFlight() { }
        public void show() { }
    }
}
