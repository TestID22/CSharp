using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsExample
{
    class Akado : Group
    {
    
        public override void GetVoice()
        {
            Console.WriteLine("Кольщик наколи мне купола");
        }

        public override void ShowTeam()
        {
            Console.WriteLine("Ко-ко\nПетя\nПетросян\nПетяй");
        }
    }
}
