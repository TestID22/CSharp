using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPhostEntryDns
{
    class Program
    {
        static void Main(string[] args)
        {
            //получить айпиАдресса всех серверов сайта
            IPHostEntry host = Dns.GetHostEntry("www.google.com");
            foreach(var h in host.AddressList)
            {
                Console.WriteLine(h);
            }

            //request к сайту и симпл парсер
            WebRequest req = WebRequest.Create("http://www.google.com");
            WebResponse res = req.GetResponse();
            using(Stream stream  = res.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                       
                    }
                }
                res.Close();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
