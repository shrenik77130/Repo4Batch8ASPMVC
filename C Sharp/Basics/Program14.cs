/* WAP to input rollno, name and 3 subject marks of student. show student details using function */

using System;
namespace  TestNamespace
{
    public class Program14
    {
        public static void Main(string []args)
        {
            int rollno;
            string name;
            int sub1,sub2,sub3;

            Console.Write("\n Enter Student Roll Number :");
            rollno = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Student Name :");
            name = Console.ReadLine();

            Console.Write("\n Enter Mark of Sub1 :");
            sub1 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Mark of Sub2 :");
            sub2 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Mark of Sub3 :");
            sub3 = int.Parse(Console.ReadLine());

            // function pass parameters 
            showStudentDetails(rollno,name,sub1,sub2,sub3);            
        }


        public static void showStudentDetails(int rollno,string name,int submark1,int submark2,int submark3)
        {
            // Function can not access variables of other function
            // With the help of arguments copy of variables can be access

            Console.Write("\n Roll Number = " + rollno);
            Console.Write("\n Student Name = " + name);
            Console.Write("\n Subject Marks = " + submark1 + "\t" + submark2 + "\t" + submark3);
        }
    }    
}

/* 
Ass1: WAP to input product code, product name, price and qtys. Define function to calculate and
show total bill amount.

Ass2: WAP to input radius, base, height and side. Define 3 functions to calculate and print area
of circle, triangle and square 

*/