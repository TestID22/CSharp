using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    class Level
    {
        public int currentExp = 0;
        public Level()
        {

        }

        void GetExp(Monster monster)
        {
            if(monster.hp <= 0)
            {
                currentExp += monster.exp;
            }
        }
    }
}
