using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Координатная плоскость при помощи вложенного цикла";
            Coordinate table = new Coordinate(10, 10);

            Console.WriteLine("Введите координаты \n Первая координата");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую координату");
            int y = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Player player = new Player(x, y);
            while (true)
            {
                player.setPlayerX(x);
                player.setPlayerY(y);
                table.CreateTable();
                table.ShowTable(player);
                Thread.Sleep(1000);
                Console.Clear();
                x++;
                y++;
            }
            
            Console.ReadLine();
        }
    }
}
