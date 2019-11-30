using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace MyHttpListener
{
    class Program
    {
        readonly static string indexPage = "d:/ServerData/index.txt";
        static void Main(string[] args)
        {
            ConfigurateDirectory();

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();

            HttpListenerContext context = listener.GetContext();
            HttpListenerResponse response = context.Response;
            // создаем ответ в виде кода html
            string responseStr = "<html><head><meta charset='UTF - 8'><body><p>HI</body></head></html>";

            byte[] buffer = GetHtmlFile();

            // получаем поток ответа и пишем в него ответ
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            // закрываем поток
            output.Close();
            // останавливаем прослушивание подключений
            listener.Stop();
            Console.WriteLine("Обработка подключений завершена");

            Console.Read();

        }
        //Создание директории для хранения файлов.
        private static void ConfigurateDirectory()
        {
            Directory.CreateDirectory("d:/ServerData");
            Thread.Sleep(1000);
            using (FileStream fs = new FileStream(indexPage, FileMode.OpenOrCreate, FileAccess.ReadWrite));
        }

        //читаем Html из текстового файла
        public static byte[] GetHtmlFile()
        {
           using(StreamReader sr = new StreamReader(indexPage))
            {
                byte[] byteHtml = Encoding.UTF8.GetBytes(sr.ReadToEnd());
                return byteHtml;
            }
        }

    }
}
