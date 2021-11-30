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
            var table = operation($"SELECT * FROM [dbo].[Users] WHERE (NickName = '{Nickname}' and Pass = '{Pass}')");
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
    }
}
