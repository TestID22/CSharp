using System;
using System.IO;
using System.Net;
using System.Text;

namespace HTTPServerReturnHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            //MakeWebRequest();
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp("http://girnyk.dn.ua");
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(resp.Headers);

            Console.ReadLine();
        }

        #region WebRequest 
        private static void MakeWebRequest(string url)
        {
            WebRequest req = WebRequest.Create(url);
            WebResponse resp = req.GetResponse();
            using (Stream stream = resp.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
        #endregion

        public static void MakeHttpWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            using(Stream stream = resp.GetResponseStream())
            {
                using(StreamReader reader = new StreamReader(stream))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }
    }
}
