/* WAP to search Array value */


using System;

namespace TestNamespace
{
    public class Program10
    {
        public static void Main(string []args)
        {
            int []numbers = {18,41,125,51,214,214};

            int user_value;
            Console.Write("Enter value to Search :");
            user_value = int.Parse(Console.ReadLine());

            int pos=-1;
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]==user_value)
                {
                        pos=i;
                }
            }

            if(pos==-1)
            {
                Console.Write("Not Exist");
            }
            else
            {
                Console.Write("Value found at index number " + pos);
            }
        }
    }
}


/* 
Ass1: WAP to create array of name of 10 cities. Some city name keep empty. and solve following questions
     Q1. Print count of empty city names
     Q2. Print cities which are duplicates
     Q3. Print count of cities begins with any vowel

Ass2: WAP to input array of 5 integer numbers. Sort in Ascending Order.

*/