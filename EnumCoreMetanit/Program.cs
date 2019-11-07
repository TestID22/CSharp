using System;

namespace EnumCoreMetanit
{
    enum Operator
    {
        Up,
        Down,
        Left,
        Rigth

    }
    class Program
    {
        static void Main(string[] args)
        {
            int corX = 10;
            int corY = 10;
            Console.WriteLine($"{corX}, {corY}");

            Move(ref corX, ref corY, Operator.Up);
            Move(ref corX, ref corY, Operator.Left);

            Console.WriteLine($"X = {corX} Y = {corY}");
            Console.ReadLine();

        }

        public static void Move(ref int x, ref  int y, Operator op)
        {
            switch (op)
            {
                case Operator.Up:
                    {
                        x += 0;
                        y -= 1;
                    }break;
                case Operator.Down:
                    {
                        x += 0;
                        y += 1;
                    }
                    break;
                case Operator.Left:
                    {
                        x += 1;
                        y += 0;
                    }
                    break;
                case Operator.Rigth:
                    {
                        x -= 1;
                        y += 0;
                    }
                    break;
            }

        }
    }
}
