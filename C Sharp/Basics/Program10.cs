
using System;

namespace TestNamespace
{
    public class Program10
    {
        public static void Main(string []args)
        {
            int []numbers = {18,41,125,51,214,11};

            int max=numbers[0];
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]>max)
                {
                    max=numbers[i];
                }
            }

            Console.Write("\n Array value " + max + " is Max");
        }
    }
}