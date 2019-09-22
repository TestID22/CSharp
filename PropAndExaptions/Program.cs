using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropAndExaptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.SetName("Вася");
            Console.WriteLine(p.Name);
            Console.ReadLine();
        }
        
    }
}
