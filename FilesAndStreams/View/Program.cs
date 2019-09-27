using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Загрузить юзера?  \n1.Да" +
                                                    "\n2.Нет" +
                                                    "\n3.Удалить данные" +
                                                    "\n4.Ввести новые данные" +
                                                    "\n5.Очистка консоли");

                var download = int.Parse(Console.ReadLine());
                switch (download)
                {
                    case (1):
                        {
                            Controller.LoadUser();
                        }
                        break;
                    case (2):
                        {
                            break;
                        }
                    case (3):
                        {
                            Controller.DelUsers();
                            Console.WriteLine("Данные удалены");
                        }
                        break;
                    case (4):
                        {
                            CreateUser();
                        }
                        break;
                    case (5):
                        {
                            Console.Clear();
                            
                        }  
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }

        private static void CreateUser()
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            var age = Console.ReadLine();
            User user = new User(name, age);

            Controller.SaveUser(user);
        }
    }
}
