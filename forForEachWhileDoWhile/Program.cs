using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forForEachWhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            var random = new Random();
            //цвет текста консоли
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = prev;

            //for
            for (int i = 0; i < 10; i++)
            {
                name.Add(random.Next(0, 100).ToString());
            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("-------------------Работа цикла foreach------------------");
            Console.ForegroundColor = prev;


            //foreach
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------Работа цикла while------------------");
            Console.ForegroundColor = prev;
            //цикл while - цикл с предусловием
            int count = 10;
            while (count > 0)
            {
                Console.WriteLine(count - 1);
                count--;
            }

            do
            {
                Console.WriteLine("В цикле с постусловием часть кода в теле DO выполняется" +
                    "в любом случае");
            }
            while (count < 10);
            {
                Console.WriteLine("не работает");
            }
           

            Console.ReadLine();

        }
    }
}
