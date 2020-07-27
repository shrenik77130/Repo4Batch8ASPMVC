/* WAP to create class "Student". demonstrate class attributes, access modifiers and class-object */

using System;

namespace TestNamespace
{

    class Student
    {
        // default access modifier is "private"
        public int rollno;
        public string studname;
        public float pert;
    }


    public class MainApp
    {
        public static void Main(string []args)
        {
            // Objects are to reserve memory space where record for class can be hold
            // Any number of object you can create

            Student s1 = new Student();
            s1.rollno = 101;
            s1.studname = "Pranav";
            s1.pert = 98.23f;

            Student s2 = new Student();
            s2.rollno = 102;
            s2.studname = "Manish";
            s2.pert = 78.23f;


            Console.Write("\n First Student");
            Console.Write("\n Roll Number = " + s1.rollno);
            Console.Write("\n Name = " + s1.studname);
            Console.Write("\n Percentage = " + s1.pert);

            Console.Write("\n Second Student");
            Console.Write("\n Roll Number = "+ s2.rollno);
            Console.Write("\n Name = " + s2.studname);
            Console.Write("\n Percentage = " + s2.pert);

        }
    }
}