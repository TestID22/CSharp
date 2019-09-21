using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesigner
{
    class MainApp

    {
        static void Main(string[] args)
        {
            var toyota = new Toyota();
            Car nissan = new Nissan();
            Console.WriteLine("Введите количество шин для Марки Тойота");

            toyota.wheels = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество шин для Ниссана");
            nissan.wheels = int.Parse(Console.ReadLine());

            var SumWheels = toyota + nissan;

            Console.WriteLine("Перегруженный оператор суммирует колёса марок \n Итого:" +
                ""  + SumWheels.wheels + "шин");
            Console.ReadLine();
        }
    }
}
