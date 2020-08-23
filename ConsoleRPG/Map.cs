using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Map
    {
        Hero hero;
        Weapon weapon;
        Monster enemy;


        public Map()
        {
            InitializeGame();
            StartGame();
        }

        //Init block create gameObj
        private void InitializeGame( )
        {
            if (this.hero == null)
            {
                CreateHero();
            }
            this.weapon = GenerateWeapon();
            this.enemy = GenerateOgr();

        }

        private Monster GenerateOgr()
        {
            return new Monster(100, 20);
        }   

        private void CreateHero()
        {
            Console.WriteLine("Введите имя персонажа");
            string name = Console.ReadLine();
            this.hero = new Hero(name);
        }
        //Get randow weapon 
        private Weapon GenerateWeapon()
        {
            Random r = new Random();
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("Нож", 33));
            weapons.Add(new Weapon("Финка", 43));

            int randomWeapon = r.Next(0, weapons.Count);
            return weapons[randomWeapon];
        }

        //Сюжетная линия lol
        void StartGame()
        {
            Console.WriteLine($"{hero.name} видит {weapon.weaponName}\n" +
                $"Хотите поднять?");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                hero.UpWeapon(weapon);
            }
            hero.GetHeroInfo();
        }

    }

}
