using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ADOdataFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тип база данных, берём данные из App.config
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            //Строка подключения
            string conString = ConfigurationManager.AppSettings["con"];

            Console.WriteLine("{0} \n {1}", dataProvider, conString);

            //получить фабрику поставщиков данных(можем менять поставщиков, не меняя код)
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            //получить объект подключения
            using (DbConnection con = factory.CreateConnection())
            {
                if(con == null)
                {
                    ShowError("Connection ERROR");
                    return;
                }
                Console.WriteLine($"Твой тип подключение {con.GetType().Name} ");
                //подключаемся
                con.ConnectionString = conString;
                con.Open();

                //Создать объект Комманды
                DbCommand command = factory.CreateCommand();
                if(command == null)
                {
                    ShowError("COMMAND ERROR");
                    return;
                }
                Console.WriteLine($"Твой тип команды {command.GetType().Name}");
                command.Connection = con;
                command.CommandText = "Select * From Inventory";//SQL запрос к БД


                using(DbDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine($"Твой тип команды {reader.GetType().Name}");
                    while (reader.Read())
                    {
                        Console.WriteLine(" \"ID\"{0} MAKE - {1}",reader["CarId"], reader["Make"]);
                    }
                }
    
            }


                Console.ReadLine();
        }
        private static void ShowError(string objectName)
        {
            Console.WriteLine($"Проблема с создание объекта {objectName}");
            Console.ReadLine();
        }

    }
}
