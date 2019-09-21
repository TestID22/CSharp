using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Car
    {
        //delegate
        public delegate void CarEngineHandler(string MsgForCaller);
        private CarEngineHandler listOFHandles;
        public void Register(CarEngineHandler methodToCall)
        {
            listOFHandles = methodToCall;
        }
        //propretiees and fields
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        public bool CarIsDead;

        //constructors
        public Car(){}

        public Car(int CurrentSpeed, int MaxSpeed, string PetName)
        {
            this.CurrentSpeed = CurrentSpeed;
            this.MaxSpeed = MaxSpeed;
            this.PetName = PetName;
        }

        //methods
        public void Acceclerate(int delta)
        {
            if (CarIsDead)
            {
                if (listOFHandles != null)
                {
                    listOFHandles("CAR IS DEAD");
                }
            }
            else
            {
                CurrentSpeed += delta;
                if(10==(MaxSpeed - CurrentSpeed) && listOFHandles != null)
                {
                    listOFHandles("Carefull");
                }
                if(CurrentSpeed > MaxSpeed)
                {
                    CarIsDead = true;
                }
                else
                    Console.WriteLine("Ваша скорость{0}", CurrentSpeed);
            }
        }



    }
}
