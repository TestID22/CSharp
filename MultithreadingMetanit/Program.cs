using System;
using System.Threading;

namespace MultithreadingMetanit
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Главный Поток";
            //Поскольку потоки это рандом, то вывод метода в отдельном потоке, будет давать разный вывод.
            Thread t = new Thread(new ThreadStart(KissMeImMulti));
            t.Start();
            t.Name = "Второстепенный поток";
            //Этот метод в главном потоке, он будет работать псевдопараллельно с потоком KissMe.
            MainTreadMethod();
            
            Console.WriteLine($"Имя главного потока:{thread.Name}\nИмя потока номер 2:{t.Name}");
            
            Console.ReadLine();
        }

        private static void MainTreadMethod()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Считаю до 50");
            for (int i = 1; i <= 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Первый Поток {i}");
            }
        }

        public static void KissMeImMulti()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Считаю от 50 до 100");
            for (int i = 50; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Второй Поток: {i}");

            }
        }
    }
}
