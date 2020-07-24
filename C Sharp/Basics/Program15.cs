/* WAP to define function to print reverse of a number */

using System;

namespace TestNamespace
{
    public class Program16
    {
        public static void Main(string []args)
        {
            int no;

            Console.Write("\n Enter any Number :");
            no = int.Parse(Console.ReadLine());  //3841

            int ans = findReverse(no);
            Console.Write("\n Answer = " + ans);
            
        }


        public static int findReverse(int x)
        {
            int rem,rev=0;
            while(x>0)
            {
                rem=x%10;
                rev=rev*10+rem;
                x=x/10;
            }

            // 1483
            return rev;
        }
    }
}