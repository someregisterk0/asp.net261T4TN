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

        public Account Login(string usr, string pwd)
        {
            usr = usr.Replace("'", "");
            usr = usr.Replace("--", "");
            string sql = $"SELECT * FROM Account WHERE Username = '{usr}' AND Password = '{pwd}'";

            IDbConnection connect = new SqlConnection(connectionString);

            IDbCommand command = connect.CreateCommand();
            command.CommandText = sql;

            connect.Open();
            IDataReader reader = command.ExecuteReader();
            Account obj = null;
            if(reader.Read())
            {
                obj = new Account()
                {
                    Id = (Guid)reader["AccountId"],
                    Username = (string)reader["Username"],
                    Email = (string)reader["Email"]
                };
            }
            reader.Close();

            connect.Close();

            return obj;
        }

        public int ChangePassword(string usr, string oldPwd, string newPwd)
        {
            string sql = $"UPDATE Account SET Password = '{newPwd}' WHERE Username = '{usr}' AND Password = '{oldPwd}'";
            return ExcuteSQL(sql);
        }
    }
}
