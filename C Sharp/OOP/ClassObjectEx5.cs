/* WAP to create class Product. Create 5 Records of Product using Aray of Objects */

using System;

namespace TestNamespace
{

    class Product
    {
        public int prodcode;
        public string prodname;
        public float price;
        public int qtys;

        public void addProduct(int prodcode, string prodname,float price,int qtys)
        {
            this.prodcode = prodcode;
            this.prodname = prodname;
            this.price = price;
            this.qtys = qtys;
        }

        public void showProduct()
        {
            Console.WriteLine(this.prodcode + "\t" + this.prodname + "\t" + this.price + "\t" + this.qtys);
        }
    }


    public class MainApp
    {
        public static void Main(string []args)
        {
            Product []prodObjects = new Product[5];

            prodObjects[0] = new Product();
            prodObjects[0].addProduct(130,"Mouse",900.00f,4);

            prodObjects[1] = new Product();
            prodObjects[1].addProduct(131,"Keyboard",1700.00f,4);

            prodObjects[2] = new Product();
            prodObjects[2].addProduct(132,"Monitor",6000.00f,1);

            prodObjects[3] = new Product();
            prodObjects[3].addProduct(133,"Speaker",2100.00f,3);

            prodObjects[4] = new Product();
            prodObjects[4].addProduct(134,"RAM",1300.00f,4);

            for(int i=0;i<prodObjects.Length;i++)
            {
                prodObjects[i].showProduct();
            }


        }
    }
}