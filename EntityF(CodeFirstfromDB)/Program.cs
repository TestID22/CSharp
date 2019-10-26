using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityF_CodeFirstfromDB_.EF;



namespace EntityF_CodeFirstfromDB_
{
    class Program
    {
        static void Main(string[] args)
        {
            int carID = AddCar();

            Console.WriteLine(carID);

            PrintAllInventory();

            Console.ReadLine();

        }

        public static int AddCar()
        {
            using(var context = new AutoLotEntities())
            {
                try
                {
                    var car = new Car { 
                                        Make = "Lada",
                                        Color = "White",
                                        PetName = "WindRunner"
                                        };

                    context.Cars.Add(car);
                    context.SaveChanges();
                    return car.CarId;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0}", ex.Message);
                    return 0;
                }
            }

        }

        public static void PrintAllInventory()
        {
            using(var context = new AutoLotEntities())
            {
                foreach(Car c in context.Cars)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
