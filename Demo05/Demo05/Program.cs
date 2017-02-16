using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons myFriends = new Persons();

            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Kernel", SocialSecurityNumber = "121212-122" };
            Person person2 = new Person { Firstname = "Masa", Lastname = "Mainio", SocialSecurityNumber = "131313-133" };
            Person person3 = new Person { Firstname = "Matti", Lastname = "Nykänen", SocialSecurityNumber = "070707-007" };

            myFriends.AddPerson(person1);
            myFriends.AddPerson(person3);
            myFriends.AddPerson(person2);

            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Ei löydy! ");
            }

            myFriends.PrintData();

            string SocialSecurityNumber = "070707-007";
            Console.WriteLine("Etsi sotu: " + SocialSecurityNumber);
            Person person5 = myFriends.FindPerson(SocialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Ei löydy ks sotua! ");
            }
        }
    }
}
