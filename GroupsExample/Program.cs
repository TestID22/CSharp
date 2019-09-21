using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Group[] groups = new Group[2];

            LP chester = new LP();
            Akado adashev = new Akado();

            chester.Name = "Честер Беннигтон";
            adashev.Name = "Петя";
            chester.Age = 25;
            adashev.Age = 100;
            
            groups[0] = chester;
            groups[1] = adashev;


            foreach(Group g in groups)
            {
                Console.WriteLine(g.Name);
                Console.WriteLine(g.Age);
                g.GetVoice();
               
            }
            for(int i = 0; i < groups.Length; i++)
            {
                groups[i].ShowTeam();
            }

            Console.ReadLine();

        }
    }
}
