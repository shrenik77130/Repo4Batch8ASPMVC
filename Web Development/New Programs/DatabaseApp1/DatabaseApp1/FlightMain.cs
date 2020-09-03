using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp1
{
    class FlightMain
    {
        static void Main(string[] args)
        {
            // Calls Constructor Function
            Flight f1 = new Flight();
            f1.saveFlight();

            Console.ReadKey();
        }
    }
}
