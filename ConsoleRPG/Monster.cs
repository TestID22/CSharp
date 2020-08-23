using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    public class Monster
    {
        public int hp { get; set; } = 100;
        public int exp = 50;

        public Monster(int hp, int exp)
        {
            this.hp = hp;
            this.exp = exp;
        }
    }
}
