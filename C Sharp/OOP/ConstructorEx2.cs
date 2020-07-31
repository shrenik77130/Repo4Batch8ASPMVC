/* WAP to demonstrate multiple constructors in a class */


using System;
namespace TestNamespace
{
    class Area
    {
        public float rad,bs,ht,side;

        public Area()
        {
            this.rad = this.bs = this.ht = this.side = 1.5f;
        }

        public Area(float rad,float bs,float ht,float side)
        {
            this.rad = rad;
            this.bs = bs;
            this.ht = ht;
            this.side = side;
        }

        public void calcArea()
        {
            float areac = 3.14f*this.rad*this.rad;
            Console.Write("\n Area of Circle = " + areac);

            float areat = 0.5f*bs*ht;
            Console.Write("\n Area of Triangle = " + areat);

            float areas = side*side;
            Console.Write("\n Area of Square = " + areas);
        }
    }


    public class MainApp
    {
        public static void Main(string []args)
        {
            //Default
            Area s1 = new Area();
            s1.calcArea();


            //Parameterized
            Area s2 = new Area(8.4f,8.2f,9.8f,7.5f);
            s2.calcArea();
        }
    }
}