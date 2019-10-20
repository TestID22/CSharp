using SimpleSerialization.Controller;
using SimpleSerialization.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загрузить Хакера - 1\nСоздать Хакера -2");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case ("1"):
                    {
                        Hacker hacker =  HackerController.Load();
                        Console.WriteLine(hacker);
                        break;
                    }
                case ("2"):
                    {
                        Console.WriteLine("Введите имя");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите способность");
                        string skill = Console.ReadLine();

                        HackerController hackerController = new HackerController(name, skill);
                        Console.WriteLine(hackerController.hacker);
                        break;
                    }

            }
            Console.ReadLine();

        }
        
        



    }
}
        
