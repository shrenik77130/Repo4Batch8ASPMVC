/* WAP to create class Employee. Create and show records of 5 employees using dynamic/anonymous objects */

using System;

namespace TestNamespace
{
    public class Employee
    {
        public int empcode;
        public string empname;
        public double salary;

        public Employee()
        {
            this.empcode = 1;
            this.empname = "#UnknownEmpName";
            this.salary = 0;
        }

        public Employee(int empcode, string empname, double salary)
        {
            this.empcode = empcode;
            this.empname = empname;
            this.salary = salary;
        }

        override
        public string ToString()
        {
            return this.empcode + "\t" + this.empname + "\t" + this.salary;
        }
    }
    public class MainApp
    {
        public static void Main(string []args)
        {
            //Method-1
            Employee []empRecords = new Employee[5];

            empRecords[0] = new Employee(101,"Santosh",9000.00);
            empRecords[1] = new Employee(102,"Nikhil",7000.00);
            empRecords[2] = new Employee(103,"Niraj",7800.00);
            empRecords[3] = new Employee(104,"Vijay",18000.00);
            empRecords[4] = new Employee(105,"Neha",16000.00);

            //Method-2
            Employee []moreEmpRecords = {
                new Employee(101,"Santosh",9000.00),
                new Employee(102,"Nikhil",7000.00),
                new Employee(103,"Niraj",7800.00),
                new Employee(104,"Vijay",18000.00),
                new Employee(105,"Neha",16000.00)
            };


            Console.Write("\n Employee Records  = ");
            showRecords(empRecords);

            Console.Write("\n More Employee Records  = ");
            showRecords(moreEmpRecords);

        }

        public static void showRecords(Employee []data)
        {
            for(int i=0;i<data.Length;i++)
            {
                // Internally Object while printing calls ToString() Method
                Console.WriteLine(data[i]);
            }
        }
    }
}