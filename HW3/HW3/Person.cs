using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Person
    {
        public Person(string name, string surname)
        { 
            Name = name;
            Surname = surname;
        }   
        public string Name { get; }

        public string Surname { get; }   //field

        public string BirthDate { get; set; }  //field

        public string Hobby { get; set; }  //field

        public string Gender { get; set; }  //field

        public string SayHi()                  //method
        {
            string greet = "Hello my name is " + Name + " " + Surname + ".";
            return greet;
        }
    }
}
