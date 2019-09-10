using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }

            string[] commandArgs = Environment.GetCommandLineArgs(); //возарвтит все аргументы командной строки
           
            string dirName = commandArgs[0];
            Console.WriteLine(dirName);
            Console.ReadLine();
        }
    }
}
