using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arratListEnum
{
    class Program
    {
            //Перечисления ENUM
            enum Romanic
            {
                I,
                II,
                III,
                IV,
                V,
                VI,
                VII,
                VIII,
                IX
            }

        static void Main(string[] args)
        {
            //двумерный массив
            int[,] ages = new int[10,10];
            ages[0,0] = 10;
            ages[9,9] = 1;
            Console.WriteLine(ages[0, 1]);


            //Список 
            List<string> hackers = new List<string>(10);

            hackers.Add("Elliot");
            hackers.Add("Darling");
            Console.WriteLine(hackers.ElementAt(1));

            Console.WriteLine(Romanic.IX);
            Console.ReadLine();
        }
    }
}
