using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.DAtaController;
using AutoLotDAL.Model;


namespace AutoLOTClient
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryDAL Dal = new InventoryDAL();

            List<Car> allCars = Dal.GetAllInvetory();
            foreach (Car c in allCars)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(Dal.GetCAR(2));

            Console.ReadLine();
        }
    }
}
