using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entities;

namespace DatabaseLayer
{

    public static class DefaultOperations
    {
        private readonly static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Autoservice; Integrated Security=True;";
        //private static SqlConnection connection = new SqlConnection(connectionString);
        delegate List<List<object>> DBOperation(params string[] operations);
        /// <summary>
        /// Выполняет любой набор операций строковых sql-запросов (одну или массив)
        /// </summary>
        /// <param name="operation">Одна операция</param>
        /// <param name="operations">Массив операций</param>
        /// <example>"INSERT INTO [dbo].[Student]([Name],[Group],[AvgMrk])VALUES('Иванов', '1234', 8.5)"</example>
        private static DBOperation operation = delegate (string[] operations)
        {
            var result = new List<List<object>>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    if (operations != null)
                    {
                        foreach (var operation in operations)
                        {
                            SqlCommand cmd = new SqlCommand(operation, connection);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var row = new List<object>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        row.Add(reader.GetValue(i));
                                    }
                                    result.Add(row);
                                }
                            }
                        }
                    }
                }
                finally { }
                connection.Close();
            }
            return result;
        };

        public static List<User> GetUsers()
        {
            var table = operation($@"SELECT * FROM [dbo].[Users]");
            var userList = new List<User>();
            for (int row = 0; row < table.Count; row++)
            {
                userList.Add(new User()
                {
                    id = (int)table[row][0],
                    NickName = (string)table[row][1],
                    Pass = (string)table[row][2],
                    User_Type = (bool)table[row][3]
                });
            }
            return userList;
        }

        public static User GetUser(string Nickname, string Pass)
        {
            User user = null;
            var table = operation($"SELECT * FROM [dbo].[Users] WHERE (NickName = '{Nickname}' AND Pass = '{Pass}')");
            if (table.Count == 0)
            {
                return null;
            }
            var row = table[0];
            user = new User() { 
                id = (int)row[0], 
                NickName = (string)row[1], 
                Pass = (string)row[2], 
                User_Type = (bool)row[3] 
            };
            return user;
        }

        public static List<Car> GetCars()
        {
            var table = operation($@"SELECT * FROM [dbo].[Car]");
            var carList = new List<Car>();
            for (int row = 0; row < table.Count; row++)
            {
                carList.Add(new Car()
                {
                    id = (int)table[row][0],
                    IsTruck = (bool)table[row][1],
                    Model = (string)table[row][2],
                    CarType = (string)table[row][3],
                    Manufacturer = (string)table[row][4],
                    CarAssembly = (string)table[row][5],
                    CarNumber = (string)table[row][6],
                    StatusId = table[row][7] is System.DBNull ? -1 : (int)table[row][7]
                });
            }
            return carList;
        }

        public static string GetCarStatus(int id)
        {
            var table = operation($@"SELECT * FROM [dbo].[CarStatus] WHERE id = {id}");
            if (table.Count == 0)
                return "";
            else
                return (string)table[0][1];
        }

        public static List<Car> SearchCars(Car car)
        {
            string query = "SELECT * FROM [dbo].[Car] WHERE ";

            #region Hard logic
            var list = new List<string>();
            if (car.IsTruck)
            {
                list.Add("IsTruck = 1");
            }
            else
            {
                list.Add("IsTruck = 0");
            }

            if (car.Model != string.Empty)
            {
                list.Add($"Model = '{car.Model}'");
            }
            
            if (car.CarType != string.Empty)
            {
                list.Add($"CarType = '{car.CarType}'");
            }

            if (car.Manufacturer != string.Empty)
            {
                list.Add($"Manufacturer = '{car.Manufacturer}'");
            }

            if (car.CarAssembly != string.Empty)
            {
                list.Add($"CarAssembly = '{car.CarAssembly}'");
            }

            if (car.CarNumber != string.Empty)
            {
                list.Add($"CarNumber = '{car.CarNumber}'");
            }

            if (car.StatusId != 0)
            {
                list.Add($"StatusId = {car.StatusId}");
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                query += list[i] + " AND ";
            }

            query += list[list.Count - 1];
            #endregion

            var table = operation(query);
            var carList = new List<Car>();
            for (int row = 0; row < table.Count; row++)
            {
                carList.Add(new Car()
                {
                    id = (int)table[row][0],
                    IsTruck = (bool)table[row][1],
                    Model = (string)table[row][2],
                    CarType = (string)table[row][3],
                    Manufacturer = (string)table[row][4],
                    CarAssembly = (string)table[row][5],
                    CarNumber = (string)table[row][6],
                    StatusId = table[row][7] is System.DBNull ? -1 : (int)table[row][7]
                });
            }
            return carList;
        }

        public static void AddCar(Car car)
        {
            operation($@"INSERT INTO [dbo].[Car] VALUES ({(car.IsTruck ? 1 : 0)}, '{car.Model}', '{car.CarType}', '{car.Manufacturer}', '{car.CarAssembly}', '{car.CarNumber}', {car.StatusId})");
        }

        public static void AddAccounting(Accounting carInfo)
        {
            operation($@"INSERT INTO [dbo].[Accounting] VALUES ({carInfo.CarId}, {carInfo.Milleage}, {(int)carInfo.EngineStatus}, {(int)carInfo.ChassisStatus}, {(int)carInfo.CarcassStatus})");
        }

        public static void DeleteCar(Car car)
        {
            operation($@"DELETE FROM [dbo].[Car] WHERE (IsTruck = {(car.IsTruck ? 1 : 0)} AND Model = '{car.Model}' AND CarType = '{car.CarType}' AND Manufacturer = '{car.Manufacturer}' AND CarAssembly = '{car.CarAssembly}' AND CarNumber = '{car.CarNumber}')");
        }

        public static int GetStatusId(string condition)
        {
            var table = operation($@"SELECT * FROM [dbo].[CarStatus] WHERE Condition = '{condition}'");
            if (table.Count == 0)
                return 0;
            else
                return (int)table[0][0];
        }

        public static void ChangeCarStatus(int carId, int carStatusId)
        {
            operation($@"UPDATE [dbo].[Car] SET StatusId = {carStatusId} WHERE Id = {carId}");
        }
    }
}
