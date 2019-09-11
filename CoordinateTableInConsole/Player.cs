using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Player
    {
        private int PlayerX;
        private int PlayerY;

        public Player(int playerX, int playerY)
        {
           this.PlayerX = playerX;
           this.PlayerY = playerY;
        }

        public int getPlayerX()
        {
            return PlayerX;
        }

        public int getPlayerY()
        {
            return PlayerY;
        }

        public void setPlayerX(int value)
        {
            PlayerX = value;
        }
        public void setPlayerY(int value)
        {
            PlayerY = value;
        }

    }
}
