// WAP to input three numbers. check that which is max

using System;

namespace TestNamespace
{
    public class Program4
    {
        public static void Main(string []args)
        {
            int a,b,c;
            
            Console.Write("Enter value of a :");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter value of b :");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter value of c :");
            c = int.Parse(Console.ReadLine());

            if(a>b && a>c)
                Console.Write("\n a is Max");
            else if(b>a && b>c)
                Console.Write("\n b is Max");
            else
                Console.Write("\n c is Max");

        }
    }
}