using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castType
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////Приведениe Типов (Cast) ////////////////////////////
            //неявное приведение
            int number = 6;
            double dNumber = number;
            Console.WriteLine("(Компилятор сам )Приводит int :" + number + " к double " + dNumber);
            Console.WriteLine();

            //явное приведение
            int num = 5;
            byte byteNum = (byte)num;
            Console.WriteLine("Сами 'явно' приводим int " + num + " к byte " + byteNum);
            Console.WriteLine();

            ////////////////////Преобразование Типов (Conversing)//////////////////////////
            //Явное преобразование
            string numberFive = "5";
            int sNumberFive = Convert.ToInt32(numberFive);
            Console.WriteLine("Конвертим (парсим) строку к инту " + sNumberFive);
            Console.WriteLine();

            string numberParse = "42";
            int numParse = Int32.Parse(numberParse);
            Console.WriteLine("Парсим строчку" + numberParse);
            Console.WriteLine();

            //Неявное преобразование
            int numberAdd = 100;
            string stingAddnum = "Это сто " + numberAdd;
            Console.WriteLine("Компилятор видит конкатенацию и вызывает ToString к инт " + stingAddnum);
            Console.WriteLine();

            //Явное приведение через метод класса Object
            bool isTrue = false;
            string strIsTrue = Convert.ToString(isTrue);
            Console.WriteLine("Булёвку преобразуем к строке " + strIsTrue);
            Console.WriteLine();
           

            Console.ReadLine();
        }
    }
}
