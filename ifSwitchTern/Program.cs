using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifSwitchTern
{
    class Program
    {
        static void Main(string[] args)
        {
            //условный оператор и логические операторы сравнения  (&& || !)
            Console.WriteLine("Введите число, и условный оператор определит, что делать дальше");
            int input = Int32.Parse(Console.ReadLine());
            if (input > 0 && input < 10)
            {
                Console.WriteLine("от нуля до  десяти");
            }
            else
            {
                Console.WriteLine("Не 1 и не 2 и не 3 и не 10");
            }
            Console.WriteLine();

            //switch
            switch (input)
            {
                case (1):
                    Console.WriteLine("Первый кейс выполняется если инпут равен 1");
                    break;
                case (2):
                    Console.WriteLine("Двоечка");
                    break;
                default:
                    Console.WriteLine("ХЗ");
                    break;
            }

            //тернарник
            Console.WriteLine("В переменной 10?");
            var answer = input == 10 ? "да" : "нет";
            Console.WriteLine(answer);
            Console.WriteLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задание " +
                "\n 1: Ввод 3 целых чисел" +
                "\n 2: Определить наибольшее без использования циклов" +
                "\n 3: Вывести на консоль" +
                "\n 4: сравнить число на чётность с помощью switch" +
                "\n 5: провекрить на размер меньше ста с помощью тернарника");

            Console.WriteLine();
            Console.ForegroundColor = prevColor;

            Console.WriteLine("Введите первое число");
            var first = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            var second = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            var third = Int32.Parse(Console.ReadLine());

            //logic here
            if (first > second && first > third)
            {
                Console.WriteLine("Первое число больше всех {0}", first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("Второе число больше всех число {0}", second);
            }
            else
            {
                Console.WriteLine("Третье число больше всех");
            }

            //switch сравнение на чётность
            switch (first)
            {
                case (2):
                    Console.WriteLine("Число чётное");
                    break;
                case (4):
                    Console.WriteLine("Число чётное");
                    break;
                case (6):
                    Console.WriteLine("Число чётное");
                    break;
                case (8):
                    Console.WriteLine("Число чётное");
                    break;
                case (10):
                    Console.WriteLine("Число чётное");
                    break;

                default:
                    Console.WriteLine("Не чётное");
                    break;
            }


            //Проверка тернарник

            string ternFirst = first >= 100 || second >= 100 || third >= 100 ? "Какое-то число больше 100" : "Числа меньше 100";
            Console.WriteLine(ternFirst);

            

            Console.ReadLine();
        }

    }
}
