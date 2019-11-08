using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotDAL.Model
{
    public class Car
    {
        public int CarId { get; set; }

        public string Make { get; set; }

        public string Color { get; set; }
        public string PetName { get; set; }


        public override string ToString()
        {
            return $"ID: {CarId} Марка Авто: {Make}\nЦвет {Color}\nИмя {PetName}\n";
        }
    }
}