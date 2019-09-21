using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsExample
{
    class LP : Group
    {
        
        public override void GetVoice()
        {
            Console.WriteLine("Честер поёт");
        }

        public override void ShowTeam()
        {
            Console.WriteLine("Mike\nDJ\nBrad");
        }
    }
}
