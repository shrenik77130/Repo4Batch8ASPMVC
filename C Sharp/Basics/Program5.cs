// WAP to input any character and check that it is vowel or consonent

using System;

namespace TestNamespace
{
    public class Program5
    {
        public static void Main(string []args)
        {
            char ch;

            Console.Write("\n Enter any Character :");
            ch = Console.ReadKey().KeyChar;

            if(ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
                Console.Write("\n" + ch + " is Vowel");
            else
                Console.Write("\n" + ch + " is Consonent");
        }
    }
}


/*
    Ass1 : WAP to input employee gender and age. Check that employee is elegible for insuarance or 
    not in following cases
        a. Employee is Male and age is between 25 to 45
        b. Employee is Female and age is between 21 to 41


    Ass2: WAP to input three digit number and check that number is Palindrome number or not
    (Palindrome means number and its reverse came same)
*/