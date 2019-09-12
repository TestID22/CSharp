using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consoleTitleTroelsen
{
    class Program 
    {
        static void Main(string[] args)
        {
            string name;
            while (true)
            {
                
                showFirstDialog();
                name = Console.ReadLine();
                Console.WriteLine("Привет" + name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ой, цвет изменился");
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("Ой, цвет изменился " + name);
                Console.ReadLine();
                MessageBox.Show("Всё выполнено.");

            }
        }

        static void showFirstDialog()
        {
            Console.Title = "Ты лучший кого я знаю...";
            Console.WriteLine("Введи своё имя");
        }
    }
}
