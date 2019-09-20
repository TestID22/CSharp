using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace createClass
{
    //имя Класса
    class Hacker
    {
        //поле Класса, по сути простая переменная с модификатором доступа
        private string name;
        //Конструктор класса - его имя совпадает с именем Класса
        public Hacker(string name) //параметр типа string name
        {
            this.name = name; //полю класса приравнивается параметр конструктора
        }
        //метод Класса
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
