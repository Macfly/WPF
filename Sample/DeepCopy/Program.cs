using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Name = "Jack";
            p1.Age = 22;
            p1.Id = new Identity() { DateOfBirth = "05/06/89" , SocialSecurityNumber = 1122334455};

            Person p2 = new Person();
            p2 = p1.Clone();

            p1.Name = "Alex";
            p1.Age = 30;
            p1.Id = new Identity() { DateOfBirth = "09/02/85", SocialSecurityNumber =  333002244 };

            Display(p1);
            Display(p2);

        }
        
        private static void Display(Person p)
        {
            Console.WriteLine("Name" + p.Name);
            Console.WriteLine("Age" + p.Age);
            Console.WriteLine("Date of Brith" + p.Id.DateOfBirth);
            Console.WriteLine("SSN" + p.Id.SocialSecurityNumber);
        }

    }

    public class Person
    {
        public string Name{get;set;}
        public int Age { get; set; }
        public Identity Id { get; set; }

        public Person Clone()
        {
            Person copy = (Person)MemberwiseClone();
            copy.Id = Id.Clone();
            return copy;
        }

    }

    public class Identity
    {
        public int SocialSecurityNumber{get;set;}
        public string DateOfBirth{get;set;}

        public Identity Clone()
        {
            Identity copy = (Identity)MemberwiseClone();
            return copy;
        }
    }
}
