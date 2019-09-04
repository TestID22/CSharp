using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codeBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Wake up Neo...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Follow the white Rabbit");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Knock Knock NEO...");
            Console.ReadLine();

        }
    }
}
