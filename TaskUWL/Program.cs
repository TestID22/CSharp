using System;

namespace TaskUWL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Logic();
            }
        }

        private static void Logic()
        {
            Console.WriteLine("Введите высоту ёлки");
            int num_rows = Convert.ToInt32(Console.ReadLine());
            ChristmasTree(num_rows);
            Console.ReadLine();
        }

        public static void ChristmasTree(int num_row)
        {
            
            for (int y = 1; y < num_row; y++)
            {
                for (int x = 1; x < y; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine(y);
            }
            
            
        }
    }
}
