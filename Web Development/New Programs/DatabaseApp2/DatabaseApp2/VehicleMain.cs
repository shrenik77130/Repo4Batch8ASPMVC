using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp2
{
    class VehicleMain
    {
        static void Main(string[] args)
        {
            int choice;
            CarController c1 = new CarController();


            while (true)
            {
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Show Car");

                Console.Write("\n Enter Choice :");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        c1.insertNewCar();

                        break;
                    case 2:
                        c1.show();
                        break;
                    default:
                        Console.WriteLine("\n Invalid Choice");
                        break;
                }
            }


            Console.ReadKey();

        }
    }
}
