// WAP to print prime numbers between 1 to 100 using for loop

using System;
namespace TestNamespace
{
    public class Program8
    {
        public static void Main(string []args)
        {
            int no,d,cnt;

            for(no=1;no<=100;no++)
            {
                cnt=0;
                for(d=1;d<=no;d++)
                {
                    if(no%d==0)
                        cnt++;
                }

                if(cnt==2)
                    Console.Write("\t" + no);
            }

        }
    }
}

// Ass: WAP to print prime numbers between 1 to 100 using for loop in reverse order
