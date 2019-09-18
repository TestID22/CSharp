using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollection
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }

        public Person(int Age, string FirstName, string LastName)
        {
            this.Age = Age;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        //интерполяция строк в переопределении ToString()
        public override string ToString()
        {
            return $"Name {FirstName} {LastName} Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            Person temp = (Person)obj;
            if (temp != null)
            {
                if (this.Age > temp.Age)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
