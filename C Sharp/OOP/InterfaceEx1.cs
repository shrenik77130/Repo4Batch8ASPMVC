/* WAP to demonstrate Inerface */

using System;
namespace TestNamespace
{

    interface First
    {
        // by default variables in interface are public + static + constant
        //const int x=19;
        // by default functions in interface are public + abstrat 
        void showFirst();
    }

    interface Second
    {
        void showSecond();
    }

    public class Test : First, Second
    {
        public void showFirst()
        {
            Console.WriteLine("showFirst() implemented in Test Class");
        }

        public void showSecond()
        {
            Console.WriteLine("showSecond() implemented in Test Class");
        }
    }

    public class Hello : Second
    {
        public void showSecond()
        {
            Console.WriteLine("showSecond() implemented in Hello Class");
        }  
    }

    public class MainApp
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Using Object of First,");
            First f = new Test();
            f.showFirst();

            Console.WriteLine("Using Object of Test,");
            Test t = new Test();
            t.showFirst();
            t.showSecond();

            Console.WriteLine("Using Object of Hello,");
            Hello h = new Hello();
            h.showSecond();
            
        }
    }
}