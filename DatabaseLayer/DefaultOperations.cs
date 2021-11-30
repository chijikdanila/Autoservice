using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Entities;

namespace DatabaseLayer
{

    public class DefaultOperations
    {
        private readonly static string connectionString = @"Data Source=DESKTOP-CD8E4R3\SQLEXPRESS; Initial Catalog=Autoservice; Integrated Security=True;";
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
                                    var raw = new List<object>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        raw.Add(reader.GetValue(i));
                                    }
                                    result.Add(raw);
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
            for (int raw = 0; raw < table.Count; raw++)
            {
                userList.Add(new User()
                {
                    id = (int)table[raw][0],
                    NickName = (string)table[raw][1],
                    Pass = (string)table[raw][2],
                    User_Type = (bool)table[raw][3]
                });
            }
            return userList;
        }

        public static User getUser(string Nickname, string Pass)
        {
            User user = null;
            var table = operation($"SELECT * FROM [dbo].[Users] WHERE (NickName = '{Nickname}' and Pass = '{Pass}')");
            if (table.Count == 0)
            {
                return null;
            }
            var raw = table[0];
            user = new User() { 
                id = (int)raw[0], 
                NickName = (string)raw[1], 
                Pass = (string)raw[2], 
                User_Type = (bool)raw[3] 
            };
            return user;
        }
    }
}
