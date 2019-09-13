using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Elliot = new Hacker("Elliot");
            
            Console.WriteLine("1:Взломать Корпроацию зла");
            int handle = Int32.Parse(Console.ReadLine());
            switch(handle)
            {
                case (1):
                    Elliot.hackCoorpEvil();
                    break;
                case(2):
                    Elliot.GoToTyrell();
                    break;
                default:
                    Console.WriteLine("Введите команду");
                    
                    break;
            }

            Console.ReadLine();
        }
    }
}
