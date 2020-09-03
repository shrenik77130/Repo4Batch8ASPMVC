using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseApp2
{
    class CarController
    {
        public CarController()
        {

        }

        public void insertNewCar()
        {
            int carid;
            string carname;
            string carno;
            string drivername;

            Console.Write("\n Enter Car id :");
            carid = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Car Name :");
            carname = Console.ReadLine();

            Console.Write("\n Enter Car Number :");
            carno = Console.ReadLine();

            Console.Write("\n Enter Driver Name :");
            drivername = Console.ReadLine();

  
            SqlConnection  xconn = DbConfig.connect();
            string query = "INSERT INTO Car(carid,carname,carnumber,driver_name)VALUES("+carid+",'"+carname+"','"+carno+"','"+drivername+"')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = xconn;
            cmd.CommandText = query;

            xconn.Open();
            cmd.ExecuteNonQuery();
            xconn.Close();

            Console.WriteLine("\n Car Inserted in Database");
        }

        public void show()
        {
            SqlConnection xconn = DbConfig.connect();

            string query = "SELECT carid,carname,carnumber,driver_name from Car";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = xconn;
            cmd.CommandText = query;

            xconn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (true)
            {
                if (dr.Read() == true)
                {
                    Console.WriteLine("\n " + dr["carid"].ToString() + "\t" + dr["carname"] + "\t" + dr["carnumber"]);
                }
                else
                {
                    break;
                }
            }

            xconn.Close();


        }
    }
}
