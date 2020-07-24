/* WAP to define array of names of different colors. define a function to sort array values */

using System;

namespace TestNamespace
{
    public class Program17
    {
        public static void Main(string []args)
        {
            string []colors = {"red","blue","orange","white","pink","green"};

            sortColors(colors);

            for(int i=0;i<colors.Length;i++)
            {
                Console.Write(" " + colors[i]);
            }
        }

        public static void sortColors(string []argColors)
        {
            Array.Sort(argColors);
        }
    }
}