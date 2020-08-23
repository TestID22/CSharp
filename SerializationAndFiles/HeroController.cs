using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndFiles
{
    class HeroController
    {
        public Hero MyHero {get;}

        public HeroController(string name, int hp, int mp)
        {
           if(MyHero == null)
            {
                MyHero = new Hero(name);
            }
            Save(MyHero);
        }

        public static void Save(Hero MyHero)
        {
            var formatter = new  BinaryFormatter();
            using (FileStream fs = new FileStream("hero.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, MyHero);
            }
        }

        public Hero Load()
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("hero.dat", FileMode.OpenOrCreate))
            {
                
                if(fs.Length > 0 && formatter.Deserialize(fs) is Hero item)
                {
                    return item;
                }
                return null;
                
            }
        }

        
    
    }
}
