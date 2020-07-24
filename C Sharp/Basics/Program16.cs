/* WAP to create array and show values using function */

using System;
namespace TestNamespace
{
    public class Program16
    {
        public static void Main(string []args)
        {
            int []primeNums = {19,5,7,11,43,97};

            showArrayValues(primeNums);
        }

            
        public static void showArrayValues(int []arr)
        {
            Console.Write("\n Array values are :");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }

}