﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Persons
    {
        private List<Person> persons;

        public Persons()

        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)

        {
            persons.Add(person);
        }

        public Person GetPerson(int index)

        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string SocialSecurityNumber)

        {
            foreach(Person person in persons)

            {
                if (SocialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }

            return null;
        }

        public void PrintData()

        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

        
    }
}
