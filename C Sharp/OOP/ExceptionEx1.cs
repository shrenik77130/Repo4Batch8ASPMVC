/* WAP to handle division error */

using System;
namespace TestNamespace
{
    public class MainApp
    {
        public static void Main(string []args)
        {
            int no,d;
            float ans;       

            Console.Write("\n Enter Number :");     
            no = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Divisor :");
            d = int.Parse(Console.ReadLine());

            try
            {
                //observe and pass error in catch block
                ans = no/d;
                Console.WriteLine("\n Division = " + ans);
            }
            catch(Exception ex)
            {
                //action
                Console.WriteLine("Handled Exception = " + ex);
            }
            


            // 100 Lines Code

            Console.WriteLine("\n Main App End");
        }
    }
}