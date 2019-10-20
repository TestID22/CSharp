using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialization.MODEL
{
    [Serializable]
    public class Hacker
    {
        public string Name { get; set; }

        public string Skill { get; set; }

        public override string ToString()
        {
            return $"{Name }   {Skill}";
        }
    }
}
