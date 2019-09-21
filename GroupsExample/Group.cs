using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsExample
{
    abstract class Group
    {
        public string Name { set; get;}
        public int Age;

        public abstract void GetVoice();

        public abstract void ShowTeam();
    }
}
