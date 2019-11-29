using System;
using System.IO;
using System.Net;

namespace MyHttpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();

            HttpListenerContext context = listener.GetContext();
            HttpListenerResponse response = context.Response;
            // создаем ответ в виде кода html
            string responseStr = "<html><head><meta charset='UTF - 8'><body><p>HI</body></head></html>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);

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
    }
}
