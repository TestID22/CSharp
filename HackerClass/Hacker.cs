using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace createClass
{
    class Hacker
    {
        private string name;

        public Hacker(string name)
        {
            this.name = name;
        }
        public void hackCoorpEvil()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string logInSystem = "login:Eliot";
            char[] charLog = logInSystem.ToCharArray();
            Thread.Sleep(1000);

            for(int i = 0; i < charLog.Length; i++)
            {
                
                 Console.Write(charLog.ElementAt(i));
                 Thread.Sleep(100);
            }

            Console.Write("\n");
            Console.WriteLine("password:*******");
        }
        public void GoToTyrell()
        {
            Console.WriteLine("Иду к Тайлеру");
        }

        public override string ToString()
        {
            string tmp;
            tmp = string.Format("Имя {0}", name);
            return tmp;
            
        }
    }
}
