using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropAndExaptions
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void SetName(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("Введите имя");
            }

            this.Name = Name;
        }
    }
}
