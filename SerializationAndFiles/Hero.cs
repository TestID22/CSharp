using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndFiles
{
    [Serializable]
    public class Hero
    {
        public string Name { get; } = "Чмунька";
        public int HealthPoint { get; set; } = 100;

        public int ManaPoint { get; } = 100;

        public Hero(string name, int healthPoint = 100, int manaPoint=100)
        {
            Name = name;
            HealthPoint = healthPoint;
            ManaPoint = manaPoint;
        }

        public override string ToString() => Name;
       
    }
}
