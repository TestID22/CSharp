using SimpleSerialization.MODEL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialization.Controller
{
    class HackerController
    {
        public Hacker hacker;

        const string DataFile = "hacker.dat";

        public HackerController(string name, string skill)
        {
            hacker = new Hacker { Name = name, Skill = skill };
            Save(hacker);
            
        }

        public static void Save(Hacker hacker)
        {
            BinaryFormatter farmatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(DataFile, FileMode.OpenOrCreate))
            {
                farmatter.Serialize(fs, hacker);
            }

        }

        public static Hacker Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(DataFile, FileMode.OpenOrCreate))
            {
               if(fs.Length > 0 && formatter.Deserialize(fs) is Hacker hacker)
                {
                    return hacker;
                }
                return default(Hacker);
            }
            
        }
       
    }
}
