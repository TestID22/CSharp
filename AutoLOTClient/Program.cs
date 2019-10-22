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

            ShowAllCars(Dal);
            Console.WriteLine("1- добавить машину\n2-удалить машину");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case (1):
                    {
                        InsertNewCar();
                        break;
                    }
                case (2):
                    {
                        DelCar(Dal);
                        break;
                    }
            }
            Dal.Update(1, "GolfStream");


            Console.ReadLine();
        }

        private static void DelCar(InventoryDAL Dal)
        {
            Console.WriteLine("Введите айди машина для удаления");
            int DeleteId = int.Parse(Console.ReadLine());
            Dal.DeleteCar(DeleteId);
            ShowAllCars(Dal);
        }

        private static void ShowAllCars(InventoryDAL Dal)
        {
            List<Car> allCars = Dal.GetAllInvetory();
            foreach (Car c in allCars)
            {
                Console.WriteLine(c);
            }
        }

        private static void InsertNewCar()
        {
            InventoryDAL Dal = new InventoryDAL();
            Console.WriteLine("Введите марку");
            string make = Console.ReadLine();
            Console.WriteLine("Введиет цвет");
            string color = Console.ReadLine();
            Console.WriteLine("Псевдоним");
            string petName = Console.ReadLine();
            Dal.InsertAuto(make, color, petName);
        }
    }
}
