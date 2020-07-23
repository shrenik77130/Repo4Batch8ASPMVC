/* WAP to create string and demonstrate string manipulation functions */

using System;

namespace  TestNamespace
{
    public class Program12
    {
        public static void Main(string []args)
        {
            string emailid="sumit163@gmail.com";

            Console.Write("\n Email Id = " + emailid);

            Console.Write("\n In Uppercase = " + emailid.ToUpper());
            Console.Write("\n In Lowercase = " + emailid.ToLower());
            Console.Write("\n Total number of Characters = " + emailid.Length);

            string password = "admin";
            string confirmpwd = "Admin";

            Console.Write("\n string comparision = " + password.Equals(confirmpwd));

            string colors = "red,orange,white,blue,black";

            // Console.Write("\n Split function = ",colors.Split(new char[]{','}));

            Console.Write("\n contains method = " + colors.Contains("blue"));

        }
    }    
}

/*
Ass: WAP to input mobile number including conuntry code and check that it is correct or not

1. country code should be for india
2. mobile number should be of 10 digits
3. after country code should be space
4. all should be digits
5. mobile number should begin with either 7, 8 or 9

*/