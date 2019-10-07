using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtocessKill
{
    class Program
    {
        static void Main(string[] args)
        {

            KillerP.LoadAllProcess();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Введите процесс который мы жестоко убъём");
            int processIdNumber = int.Parse(Console.ReadLine());
            KillerP.GetProcess(processIdNumber);

            OpenUrlInBrows();
            Console.ReadLine();
        }

        private static void OpenUrlInBrows()
        {
            Console.WriteLine("Введите ваш браузер и сайт");
            string startProcessName = Console.ReadLine();
            string url = Console.ReadLine();
            KillerP.Start(startProcessName, url);
        }
    }

}
