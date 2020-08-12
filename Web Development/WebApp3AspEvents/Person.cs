using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebApp3AspEvents
{
    [Serializable]
    public class Person 
    {
        public int personid;
        public string personname;
        public string gender;
        public int age;

        public Person() { }

        public Person(int personid,string personname,string gender,int age) 
        {
            this.personid = personid;
            this.personname = personname;
            this.gender = gender;
            this.age = age;
        }

        public Person[] getListOfPerson()
        {
            Person[] personArray = new Person[5];

            personArray[0] = new Person(101,"Akash","Male",32);
            personArray[1] = new Person(102, "Manoj", "Male", 42);
            personArray[2] = new Person(103, "Pooja", "Female", 13);
            personArray[3] = new Person(104, "Mrunali", "Female", 43);
            personArray[4] = new Person(105, "Manish", "Male", 20);

            return personArray;
        }
    }
}