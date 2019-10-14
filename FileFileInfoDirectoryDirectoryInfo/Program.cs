using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFileInfoDirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            //объект для работы с директориями 
            DirectoryInfo dir = new DirectoryInfo("d:/");

            //получаем список(массив) файлов, и директорий
            FileInfo[] fileNames = dir.GetFiles();
            DirectoryInfo[] dirNames = dir.GetDirectories();

            //поиск картинок
            FileInfo[] jpegInfo = dir.GetFiles("*.jpg", SearchOption.TopDirectoryOnly);

            ColorText("Картинки");
            Console.WriteLine("Найдено {0} картинок", jpegInfo.Length);
            Console.WriteLine();

            ColorText("Работа с Файлами и Директориями");

            ColorText("Файлы");
            foreach (FileInfo f in fileNames)
            {
                Console.WriteLine(f.Name);
                
                if (f.Name == "27774.jpg")
                {
                    
                }
            }

            Console.WriteLine();

            ColorText("Директории");
            foreach (DirectoryInfo d in dirNames)
            {

                Console.WriteLine(d);
                if (d.Name == "22")
                {
                    d.Delete();
                }
            }
            
            ColorText("Работа с Потоком FileStream");
            Creater("d:\\ALEX.txt");
            Console.WriteLine("Введите место создание файла");
            string path = Console.ReadLine();

            Console.WriteLine("Введите данные для записи в файл");
            string data = Console.ReadLine();

            CreateAndWriteIntoFile(path, data.Split());

            
            Console.ReadLine();
        }

        private static void ColorText(string text)
        {
            //сохраняем текущий цвет текста консоли
            ConsoleColor currColor = Console.ForegroundColor;
            Console.WriteLine("///////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = currColor;
        }

        public static void Creater(string name)
        {
            FileInfo file = new FileInfo(name);
            using (FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                Console.WriteLine(fs.Length);
                

            }

        }
        /// <summary>
        /// Метод создаёт файл в указанном месте, и записывает в него данные
        /// </summary>
        /// <param name="path">Путь создания файла, и его тип</param>
        /// <param name="Names">Данные для записи в созданный файл</param>
        private static void CreateAndWriteIntoFile(string path, params string[] Names)
        {
            string[] names = Names;
            File.WriteAllLines(path, names);
            foreach(string text in File.ReadLines(path))
            {
                Console.WriteLine(text);
            }
        }
    }
}
