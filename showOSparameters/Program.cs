using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showOSparameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 60;
            ShowInfo();

            Console.ReadLine();
        }

        static void ShowInfo()
        {
            foreach(string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive {0}", drive);
            }

            Console.WriteLine("OS: " +  Environment.OSVersion);
            Console.WriteLine("Колво процессоров " +  Environment.ProcessorCount);
            Console.WriteLine("Нет платформа " +  Environment.Version);
            
        }
    }
}
