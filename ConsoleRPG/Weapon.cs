using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    public class Weapon
    {
        public int weaponAttack;
        public string weaponName;
        public Weapon(string weaponName, int weaponAttack)
        {
            this.weaponName = weaponName;
            this.weaponAttack = weaponAttack;
        }
    }
}
