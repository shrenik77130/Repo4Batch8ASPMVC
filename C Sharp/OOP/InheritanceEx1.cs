/* WAP to demonstrate Inheritance */

namespace TestNamespace
{
			class Person
			{
				public string personname;
				public string gender;
				protected int age;
				private float weight;
				private float height;
			}

            	class Employee : Person
				{
					public int empcode;
					public double salary;
					public string company;
					public string location;
				}


    public class MainApp
    {
        public static void Main(string []args)
        {
            Person p1 = new Person();
            // you can only setup person

            Employee e1 = new Employee();
            // you can setup employee + person
        }
    }
}