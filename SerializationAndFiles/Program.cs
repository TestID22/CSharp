using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание Героя");
            var name = Console.ReadLine();
            HeroController hero = new HeroController(name, 100, 100);
            LoadHero(hero);

            Console.WriteLine("Ошарашенный вор наносит вам с дух ног 10 урона");
            hero.MyHero.HealthPoint = hero.MyHero.HealthPoint - 10;

            Console.WriteLine("У вашего героя {0} HP", hero.MyHero.HealthPoint);

            Console.ReadLine();
        }

        private static void LoadHero(HeroController hero)
        {
            Console.WriteLine("Загрузить Героя ?Y-Да");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                hero.Load();
                Console.WriteLine("Имя Вашего героя {0}", hero.MyHero.Name);
            }
            else
            {
                Console.WriteLine("не загрузили");
                
            }
        }
    }
}
