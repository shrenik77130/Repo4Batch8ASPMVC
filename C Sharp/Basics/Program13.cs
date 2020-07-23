/* WAP to demonstrate functions in c sharp  */

using System;

namespace TestNamespace
{
    public class Program13
    {
        public static void Main(string []args)
        {
            //Main is static function.
            //static functions only allow static declarations and static functions
            //non-static not allowed inside static

            showHelloWorld();
            showHelloWorld();
        }

        public static void showHelloWorld()
        {
            Console.Write("\n Hello World");
        }

        // Any function can be called for any number of times
    }    
}