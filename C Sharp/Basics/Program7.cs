// WAP to print numbers between n1 and n2 using while loop

using System;

namespace TestNamespace
{
    public class Program6
    {
        public static void Main(string []args)
        {
            int n1,n2;

            Console.Write("\n Enter value of n1 :");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("\n Enter value of n2 :");
            n2 = int.Parse(Console.ReadLine());

            while(n1<=n2)
            {
                Console.Write("\t" + n1);
                n1++;
            }

            
        }
    }
}

// Ass1: WAP to input any number and print its Multiplication Table
