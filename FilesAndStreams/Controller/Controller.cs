using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreams
{
    public class Controller
    {
        public User User { get;}

        public Controller(User user)
        {
            User = user;
        }
        public static int Counter = 0;

        public static void SaveUser(User user)
        {
            using (var sw = new StreamWriter("user.txt", append:true))
            {
                Counter++;
                sw.WriteLine($"{Counter}.{user.Name}, {user.Age}");
            }
        }

        public static void LoadUser()
        {
            using (var sr = new StreamReader("user.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
        }
        public static void DelUsers()
        {
            File.Delete(@"D:\Code_Code_Code\CSharp\FilesAndStreams\bin\Debug\user.txt");
        }
    }
}
