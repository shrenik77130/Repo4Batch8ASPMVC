// WAP to input two numbers and show addition

using System;

namespace TestExample
{
    public class Program2
    {
        public static void Main(string []args)
        {
            int a;
            int b;

            Console.Write("Enter value of a :");
            a = int.Parse(Console.ReadLine());   //int.Parse("83") -> 83

            Console.Write("Enter value of b :");
            b = int.Parse(Console.ReadLine());

            int ans = a+b;
            Console.Write("Addition = " + ans);
        }
    }
}