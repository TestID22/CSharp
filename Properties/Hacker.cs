using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Hacker
    {
        private string hackersName;
        private int hackersSkill;
        private string age;

        //Properties
        public int healthPoint { get; set; } //Auto Properties
        public string power { get; set; }
        public string Name
        {
            get { return hackersName; }
            set
            {
                hackersName = value;
            }


        }
        public int Skill
        {
            get { return hackersSkill; }
            set { hackersSkill = value; }

        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public Hacker() {} //создадим стандартный "пустой" экземпляр

        public Hacker(string hackerName, string power) //объект с двумя параметрами
            :this(hackerName, 0, 0, "0", power) { }

        public Hacker(string hackersName, int hackersSkill, int healthpoint)
            :this(hackersName, hackersSkill, 100, "", ""){ }


        public Hacker(string hackerName, int hackersSkill, int healthPoint, string age, string power)
        {
            this.hackersName = hackerName;
            this.hackersSkill = hackersSkill;
            this.healthPoint = healthPoint;
            this.age = age;
            this.power = power;
        }
    }
}
