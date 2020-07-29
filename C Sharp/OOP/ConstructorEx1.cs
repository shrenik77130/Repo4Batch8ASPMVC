/* WAP to demonstrate Constructor */

using System;
namespace TestNamespace
{
    public class Message
    {
        string msg;

        public Message()
        {
            this.msg = "#UnknownMsg";
        }

        public Message(string msg)
        {
            this.msg = msg;
        }

        public void showMessage()
        {
            Console.Write("Message is " + this.msg);
        }
    }

    public class MainApp
    {
        public static void Main(string []args)
        {
                Message m1 = new Message("Hello");
                m1.showMessage();

                Message m2 = new Message();
                m2.showMessage();
        }
    }
}