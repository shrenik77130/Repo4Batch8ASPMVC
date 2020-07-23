
using System;

namespace TestNamespace
{
    public class Program9
    {
        public static void Main(string []args)
        {
            // Single Dimentional Array
            int []x = new int[5];
            x[0]=19;
            x[1]=38;
            x[2]=91;
            x[3]=18;
            x[4]=100;

            Console.Write("\n Array values x = ");
            for(int i=0;i<x.Length;i++)
            {
                Console.Write("\t" + x[i]);
            }

            // Mutli Dimentional Array
            int [,]m1 = new int[3,2];

            m1[0,0] = 11;
            m1[0,1] = 12;
            m1[1,0] = 13;
            m1[1,1] = 14;
            m1[2,0] = 15;
            m1[2,1] = 16;

            Console.Write("\n Array values y = ");
            for(int r=0;r<3;r++)
            {
                Console.WriteLine();
                for(int c=0;c<2;c++)
                {
                    Console.Write(" " + m1[r,c]);
                }
            }

        }
    }
}