using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutoLotDAL.Model;

namespace AutoLotDAL.DAtaController
{
    public class InventoryDAL
    {
        //строка подключения
        private readonly string ConntecionString;
        //объект подключения
        private SqlConnection SqlConnection = null;
        
        public InventoryDAL() :this(@"Data Source = (localdb)\mssqllocaldb; 
                                    Integrated Security = true; 
                                    Initial Catalog = AutoLot") { }
        
        
        public InventoryDAL(string conntecionString) => this.ConntecionString = conntecionString;

        private void OpenConnetction()
        {
            SqlConnection = new SqlConnection(ConntecionString);
            SqlConnection.Open();
            Console.WriteLine("{0}", SqlConnection.GetType());

        }

        private void CloseConnection()
        {
            if(SqlConnection?.State != ConnectionState.Closed)
            {
                SqlConnection?.Close();
            }
        }

        public List<Car> GetAllInvetory()
        {
            //конектимся к базе
            OpenConnetction();
            
            List<Car> inventory = new List<Car>();
            //создадим команду для запроса данных
            string command = "Select * From Inventory";
            using(SqlCommand sqlCommand = new SqlCommand(command, SqlConnection))
            {
                sqlCommand.CommandType = CommandType.Text;
                //создаём объект Чтения CommandBehavior - свойсто для закрытия подключения.
                SqlDataReader DataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                //читаем всё что есть в запросе
                while (DataReader.Read())
                {
                    inventory.Add(new Car
                    {
                        CarId = (int)DataReader["CarID"],
                        Make = (string)DataReader["Make"],
                        Color = (string)DataReader["Color"],
                        PetName = (string)DataReader["PetName"]
                    });
                }
                DataReader.Close();
            }
            return inventory;
        }

        public Car GetCAR(int id)
        {
            OpenConnetction();
            Car car = null;
            string sqlRequest = $"Select * From Inventory where CarId = {id}";
            using (SqlCommand command = new SqlCommand(sqlRequest, SqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    car = new Car
                    {
                        CarId = (int)dataReader["CarID"],
                        Make = (string)dataReader["Make"],
                        Color = (string)dataReader["Color"],
                        PetName = (string)dataReader["PetName"]
                    };
                }
                dataReader.Close();
            }
            return car;
        }



    } 
}
