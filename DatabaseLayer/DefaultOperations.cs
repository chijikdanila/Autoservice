using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DefaultOperations
    {
        private readonly static string connectionString = "";
        //private static SqlConnection connection = new SqlConnection(connectionString);
        delegate List<List<object>> DBOperation(params string[] operations);
        /// <summary>
        /// Выполняет любой набор операций строковых sql-запросов (одну или массив)
        /// </summary>
        /// <param name="operation">Одна операция</param>
        /// <param name="operations">Массив операций</param>
        /// <example>"INSERT INTO [dbo].[Student]([Name],[Group],[AvgMrk])VALUES('Иванов', '1234', 8.5)"</example>
        DBOperation operation = delegate (string[] operations)
        {
            var result = new List<List<object>>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    if (operations != null)
                    {
                        foreach(var operation in operations)
                        {
                            SqlCommand cmd = new SqlCommand(operation, connection);
                            using(SqlDataReader reader = cmd.ExecuteReader())
                            {
                                var raw = new List<object>();
                                while (reader.Read())
                                {
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

        private void Example()
        {
            var table = operation("дай юзера");
            var userList = new List<User>();
            for (int raw = 0; raw < table.Count; raw++)
            {
                userList.Add(new User() { id = (int)table[raw][0], age = (string)table[raw][1] });
            }
        }

        public User getUser(User user)
        {
            var table = operation("дай юзера");
            var raw = table[0];
            if (raw[0] == null || raw[0].ToString() == "NULL" || raw[0].ToString() == "null")
            {
                return null;
            }
            var user = new User() { id = raw[0], ... };
            return user;
        }
    }

    
    
}
