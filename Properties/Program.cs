using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cоздадим 3 объекта класса Хакер, искользуя 3 перегруженных конструктора
            Hacker elliot = new Hacker();
            Hacker darling = new Hacker("Darling", "Girl Empaty");
            Hacker tyrell = new Hacker("Tyrell", 100, 100, "34", "Hide");

            elliot.Name = "Elliot";
            elliot.Skill = 99;
            elliot.healthPoint = 50;

            List<Hacker> fsociety = new List<Hacker>(3);
            fsociety.Add(elliot);
            fsociety.Add(darling);
            fsociety.Add(tyrell);

            foreach (Hacker h in fsociety)
            {
                Console.WriteLine("Name: {0} \nSkill: {1}\nHP:{2}",
                    h.Name, h.Skill, h.healthPoint, h.power);
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
