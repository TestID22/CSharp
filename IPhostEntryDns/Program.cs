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
        static async Task Main(string[] args)
        {
            //получить айпиАдресса всех серверов сайта
            IPHostEntry host = Dns.GetHostEntry("www.google.com");
            foreach (var h in host.AddressList)
            {
                Console.WriteLine(h);
            }
            //TODO: научится вставлять свои заголовки
            //GetHtml("http://www.google.com");


            await GetServerName("http://www.girnyk.dn.ua");

            Console.WriteLine();
            Console.ReadLine();
        }
        //определить сервер
        private static async Task GetServerName(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            WebHeaderCollection headers = response.Headers;
            for (int i = 0; i < headers.Count; i++)
            {
                if (headers.GetKey(i).ToLower().Contains("server"))
                    Console.WriteLine("{0}: {1}", headers.GetKey(i), headers[i]);
            }
            response.Close();
        }

        //Получим html страницы
        private static void GetHtml(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new Exception("URL не может быть пуст или null");
            }
            //request к сайту и симпл парсер
            WebRequest req = WebRequest.Create(url);
            WebResponse res = req.GetResponse();
            using (Stream stream = res.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }
                }
                res.Close();
            }
        }
    }
}
