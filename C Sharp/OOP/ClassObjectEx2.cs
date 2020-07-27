/* WAP to create class Employee. Read Emp Id, Name and Salary. Show two records of Employees  */

using System;
namespace TestNamespace
{

    class Employee
    {
        public int empcode;
        public string empname;
        public double salary;
    }

    public class MainApp
    {
        public static void Main(string []args)
        {
            Employee e1 = new Employee();
            Console.Write("\n Enter Emp Code :");
            e1.empcode = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Emp Name :");
            e1.empname = Console.ReadLine();

            Console.Write("\n Enter Salary :");
            e1.salary = float.Parse(Console.ReadLine());


            

            Employee e2 = new Employee();
            Console.Write("\n Enter Emp Code :");
            e2.empcode = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Emp Name :");
            e2.empname = Console.ReadLine();

            Console.Write("\n Enter Salary :");
            e2.salary = float.Parse(Console.ReadLine());            

        }
    }
}