using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class AccountRepository
    {

        readonly static string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";

        public int ExcuteSQL(string sql)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = sql;

            connection.Open();
            int ret = command.ExecuteNonQuery();
            connection.Close();
            return ret;
        }

        public int Add(Account obj)
        {
           string sql = $"INSERT INTO Account(Username, Password, Email) VALUES" +
                $"('{obj.Username}', '{obj.Password}', '{obj.Email}')";

            return ExcuteSQL(sql);
        }
    }
}
