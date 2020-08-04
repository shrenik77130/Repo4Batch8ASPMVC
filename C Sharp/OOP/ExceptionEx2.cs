/* WAP to handle input error */

using System;
namespace TestNamespace
{
    public class MainApp
    {
        public static void Main(string []args)
        {
            int no;       

            try
            {
                Console.Write("\n Enter Number :");     
                no = int.Parse(Console.ReadLine());   

                Console.WriteLine("\n Number = " + no);
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