using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Generics";

            //generics Sort

            int[] sortArray = { 1, 20, 5, 2, 211 };

            Console.Write("не сортированный массив ");
            for(int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(sortArray[i] + " ");
            }

            Console.WriteLine();
            Array.Sort<int>(sortArray);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Массив сортируем ", sortArray);
            foreach(int i in sortArray){
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            //

            Person person = new Person(23, "Alex", "Sandro");
            Person person2 = new Person(25, "Gustav", "Kg");

            PersonArray persons = new PersonArray();

            persons.AddPerson(person);
            persons.AddPerson(person2);

            foreach(Person p in persons)
            {
                Console.WriteLine(p);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Обект person и person два РАВНЫ: {0}" ,person.Equals(person2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(person);

            //Generics

            List <Person> generciPerson = new List<Person>();
            generciPerson.Add(new Person(24, "Mauro", "Icardi"));

            Console.ReadLine();
        }
    }
}
