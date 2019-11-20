using System;
using System.IO;
using System.Text;
using System.Threading;

namespace FileStreamByteAndOtherClasses
{
    class Program
    {
        private const string file = "d:/FileStream.dat";
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                Console.WriteLine(args[1]);
                PutStringInStream(args[1]);
            }

            //PutCharInStream('A');
            //ReadCharFromStream();
            #region OPEN Here Steam Code
            //using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    fs.WriteByte(Convert.ToByte('a'));//Записи одного байта в поток.
            //    byte[] stringInByte = Encoding.ASCII.GetBytes("Text to byte Array");//Запись строки в массив БАЙТОВ.
            //    fs.Write(stringInByte, 0, stringInByte.Length);//запись массива байтов с 0 до последнего байта.

            //    //Читаем
            //    //установим указатель в начало потока.
            //    fs.Seek(0, SeekOrigin.Begin);
            //    Console.WriteLine($"{Convert.ToChar(fs.ReadByte())}");//читаем байт и конвертируем в Чар.

            //    Thread.Sleep(1000);
            //    Console.Clear();
            //     Буфер для записи данных из потока
            //    byte[] read = new byte[fs.Length - 1];//создаём буфер для хранения данных
            //    fs.Read(read, 0, read.Length - 1); //записываем данные из потока в буффер
            //    Console.WriteLine($"{Encoding.ASCII.GetString(read)}");
            //    Console.ReadLine();
            //}
            #endregion
            Console.ReadLine();
        }

        private static void ReadCharFromStream()
        {
            using FileStream fileOpen = new FileStream(file, FileMode.Open, FileAccess.Read);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Символ записанный в поток : {Convert.ToChar(fileOpen.ReadByte())}");
            Console.WriteLine("------------------------------------");
        }

        public static void PutCharInStream(char c)
        {
            using FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.WriteByte(Convert.ToByte(c));

        }

        public static void PutStringInStream(string text)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //готовим буффер для строки в виде массива байтов.
                byte[] textInByte = Encoding.ASCII.GetBytes(text);
                fs.Write(textInByte, 0, textInByte.Length);
            }
        }
    }
}
    

