using System;
namespace Exercises
{
    public class Person
    {
        //my class atrributes
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Fromlocation { get; set; }
        public int Age { get; set; }

        //my Constructors
        public Person(string firstname,string secondname, string fromlocation, int age)
        {
            Firstname = firstname;
            Secondname = secondname;
            Fromlocation = fromlocation;
            Age = age;
        }
    }
}
