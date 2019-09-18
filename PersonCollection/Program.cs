using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(23, "Alex", "Sandro");
            Person person2 = new Person(25, "Gustav", "Kg");

            PersonArray persons = new PersonArray();

            persons.AddPerson(person);
            persons.AddPerson(person2);

            foreach(Person p in persons)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(person.Equals(person2));
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
