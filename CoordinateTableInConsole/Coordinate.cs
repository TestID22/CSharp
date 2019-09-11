using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Coordinate
    {
        private int[,] table;
        int coordX;
        int coordY;

        Player player;


        public Coordinate (int coordX, int coordY)
        {
            player = new Player(0, 0);

            this.coordX = coordX;
            this.coordY = coordY;

            this.table = new int[coordX, coordY];
        }

        public void CreateTable()
        {
            table = new int[coordX, coordY];
            for (int y = 0; y < coordY; y++)
                for(int x = 0; x < coordX; x++)
                {
                    table[x, y] = coordX * coordY;
                }
        }

        public void ShowTable(Player player)
        {
            for (int y = 0; y < coordY; y++)
            {
                for (int x = 0; x < coordX; x++)
                {
                    if(y == player.getPlayerY() && x == player.getPlayerX())
                    {
                        Console.Write("  X  ");
                    }else
                        Console.Write("     " + " ", x, y);

                }
                Console.WriteLine();
            }
        }

    
    }
}
