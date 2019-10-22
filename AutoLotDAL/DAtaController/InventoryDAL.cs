using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutoLotDAL.Model;

namespace AutoLotDAL.DAtaController
{/// <summary>
/// CRUD with ADO.NET
/// </summary>
    public class InventoryDAL
    {
        //строка подключения
        private readonly string ConntecionString;
        //объект подключения
        private SqlConnection Connection = null;
        
        public InventoryDAL() :this(@"Data Source = (localdb)\mssqllocaldb; 
                                    Integrated Security = true; 
                                    Initial Catalog = AutoLot") { }
        
        
        public InventoryDAL(string conntecionString) => this.ConntecionString = conntecionString;

        private void OpenConnetction()
        {
            Connection = new SqlConnection(ConntecionString);
            Connection.Open();
            Console.WriteLine("{0}", Connection.GetType());

        }

        private void CloseConnection()
        {
            if(Connection?.State != ConnectionState.Closed)
            {
                Connection?.Close();
            }
        }

        public List<Car> GetAllInvetory()
        {
            //конектимся к базе
            OpenConnetction();
            
            List<Car> inventory = new List<Car>();
            //создадим команду для запроса данных
            string command = "Select * From Inventory";
            using(SqlCommand sqlCommand = new SqlCommand(command, Connection))
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
            using (SqlCommand command = new SqlCommand(sqlRequest, Connection))
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

        public void InsertAuto(string make, string color, string petName)
        {
            OpenConnetction();
            //sql запрос
            string sql = $"Insert Into Inventory (Make, Color, PetName) Values ('{make}','{color}','{petName}')";
            using (SqlCommand sqlCommand = new SqlCommand(sql, Connection))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery();
            }
            CloseConnection();
            
        }

        public void InsertAuto(Car car)
        {
            OpenConnetction();
            //sql запрос
            string sql = $"Insert Into Inventory (Make, Color, PetName) " +
                         $"Valuse('{car.Make}', '{car.Color},'{car.PetName}')";
            using (SqlCommand sqlCommand = new SqlCommand(sql, Connection))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void DeleteCar(int id)
        {
            OpenConnetction();
            string sql = $"Delete From Inventory Where CarId = '{id}'";
            using(SqlCommand sqlCommand = new SqlCommand(sql, Connection))
            {
                try
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    throw new Exception("Машина уже куплена");
                }
            }
            CloseConnection();
        }

        public void Update(int id, string petName)
        {
            OpenConnetction();

            string sql = $"Update Inventory Set PetName = '{petName}' Where CarID = '{id}'";
            using(SqlCommand sqlCommand = new SqlCommand(sql, Connection))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery();
            }
            CloseConnection();

        }

    } 
}
