using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesigner
{
    public class Car
    {
        public int wheels { set; get; } = 4;
        public int maxSpeed { set; get; } = 300;

        public Car()
        {

        }
        //перегрузка она же OVERLOADING
        public static Car operator + (Car a, Car b)
        {
            var SumWheels = a.wheels + b.wheels;
            Car car = new Car();
            car.wheels = SumWheels;
            return car;
        }
           
     


    }
}
