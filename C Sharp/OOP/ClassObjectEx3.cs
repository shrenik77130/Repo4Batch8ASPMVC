/* WAP to create class Product. Define function in class to read product code, name, price. show Product
details */

using System;
namespace TestNamespace
{
    class Product
    {
        public int prodcode;
        public string prodname;
        public float price;

        public void addProduct()
        {
            Console.Write("\n Enter Product Code :");
            prodcode = int.Parse(Console.ReadLine());

            Console.Write("\n Enter Product Name :");
            prodname = Console.ReadLine();

            Console.Write("\n Enter Price :");
            price = float.Parse(Console.ReadLine());
        }

        public void showProduct()
        {
            Console.Write("\n Product Code = " + prodcode);
            Console.Write("\n Product Name = " + prodname);
            Console.Write("\n Price = Rs." + price);
        }
    }
    public class MainApp
    {
        public static void Main(string[]args)
        {
            Product p1 = new Product();
            p1.addProduct();

            Product p2 = new Product();
            p2.addProduct();

            p1.showProduct();
            p2.showProduct();
        }
    }
}