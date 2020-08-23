
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    public class Hero
    {
        public string name { get; set; } = "Anonymous";
        int hp = 100;
        int attack = 10;
        Weapon weapon;
        Level heroLevel = new Level();

        public Hero(string name)
        {
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
    }
}
