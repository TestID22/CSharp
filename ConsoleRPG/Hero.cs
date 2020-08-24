
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleRPG
{
    public class Hero
    {
        static int id = 0;
        public string name { get; set; } = "Anonymous";
        int hp = 100;
        int attack = 10;
        Weapon weapon;
        Level heroLevel = new Level();

        public Hero(string name)
        {
            id += 1;
            this.name = name;
            this.heroLevel.currentExp = 0;
        }

        public void UpWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            this.attack += weapon.weaponAttack;
        }

        public void GetHeroInfo()
        {
            Console.WriteLine($"Имя - {name}\n" +
                $"HP - {hp}\n" +
                $"ATTACK - {attack}\n" +
                $"WEAPON - {weapon.weaponName} + {weapon.weaponAttack}\n" +
                $"EXP - {heroLevel.currentExp}");
        }
        public void SaveHero()
        {
            using(StreamWriter streamWriter = new StreamWriter("hero_from_consoleRPG.txt", true))
            {
                streamWriter.WriteLine($"Id{id}");
                streamWriter.WriteLine($"Имя героя: {this.name}");
                streamWriter.WriteLine($"Здоровье: {this.hp}");
                streamWriter.WriteLine($"Атака: {this.attack}");
                streamWriter.WriteLine($"Оружие: {this.weapon.weaponName} Атака: {this.weapon.weaponAttack}");
                streamWriter.WriteLine($"Опыт: {this.heroLevel.currentExp}");
                streamWriter.WriteLine();

            }
        }

    }
}
