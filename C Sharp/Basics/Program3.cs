// WAP to input studid, name and marks of 3 subjects.show total and percentage

using System;

namespace TestNamespace
{
    public class Program3
    {
        public static void Main(string []args)
        {
            int studid;
            string studname;
            int sub1,sub2,sub3;

            Console.Write("\n Enter Student Roll Number :");
            studid = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Student Name :");
            studname = Console.ReadLine();

            Console.Write("\n Enter Mark of Sub1 :");
            sub1 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Mark of Sub2 :");
            sub2 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Mark of Sub3 :");
            sub3 = int.Parse(Console.ReadLine());

            int total = sub1 + sub2 + sub3;
            Console.Write("\n Total Marks = " + total);

            float pert = total/3;
            Console.Write("\n Percentage = " + pert);
        }
    }
}

/*

Ass1: WAP to input two numbers and perform swapping

Ass2: WAP to input product code, product name, price and qtys. Calculate and show Total Bill Amount
with discount of 5%

Ass3: WAP to input 3 digit integer number and show its Reverse

Ass4: WAP to input 5 digit number and replace its last digit with the product of first and
last digit

Ass5: WAP to input temperature in fahreinheits and convert to degree centigrade

*/