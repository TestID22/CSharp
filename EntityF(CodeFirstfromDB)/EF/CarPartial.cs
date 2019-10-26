using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF_CodeFirstfromDB_.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{this.PetName} is a {this.Color} " +
                $"this {this.Make}  id  {this.CarId}";
        }
    }
}
