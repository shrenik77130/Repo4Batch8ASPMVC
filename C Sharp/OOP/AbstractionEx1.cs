/* WAP to demonstrate abstraction */

using System;
namespace TestNamespace
{
    public abstract class Car
    {
        public virtual void moveCar()    // this function child-class optionally override
        {
            Console.WriteLine("\n Car is Steady. not moving");
        }

        public abstract void setColor();  // this function compulsory to override
    }

        public class Bmw : Car
        {
            override
            public void setColor()
            {
                Console.WriteLine("BMW Car is in Red Color");
            }
        }

        class Auddii : Car
        {
            override
            public void moveCar()   
            {
                Console.WriteLine("\n Auddii Car is Moving Fast");
            }

            override
            public void setColor()
            {
                Console.WriteLine("Auddii Car is in White Color");
            }
        }



    public class MainApp
    {
        public static void Main(string []args)
        {
            Car c1 = new Bmw();
            c1.moveCar();
            c1.setColor();

            Car c2 =  new Auddii();
            c2.moveCar();
            c2.setColor();

        }
    }
}