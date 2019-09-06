using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII TABLE");
            for(int i = 0; i < 255; i++)
            {
                Console.WriteLine("Номер кода: " + i + "\t СИМВОЛ: " + (char)i);
            }
            Console.ReadLine();
        }
    }
}
