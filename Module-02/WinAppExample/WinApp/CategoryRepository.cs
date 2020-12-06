using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class CategoryRepository
    {
        // fields
        // const string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";
        readonly static string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";

        public List<Category> GetCategories()
        {
            //string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Category";

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();
            while (reader.Read())
            {
                Category obj = new Category()
                {
                    Id = (int)reader["CategoryId"],
                    Name = (string)reader["CategoryName"]
                };
                list.Add(obj);
            }

            reader.Close();
            connection.Close();

            return list;
        }

        public int Add(Category obj)
        {
            //string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Category VALUES (@name)";

            // Set parameter name
            IDbDataParameter nameParameter = command.CreateParameter();
            nameParameter.ParameterName = "@name";
            nameParameter.Value = obj.Name;
            command.Parameters.Add(nameParameter);

            connection.Open();

            // Giá trị trả về của ExecuteNonQuery()
            // 0: failed, 1: success
            int ret = command.ExecuteNonQuery();
            connection.Close();
            return ret;
        }

        public int Delete(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Category WHERE CategoryId = @id";

            // Set parameter name
            IDbDataParameter nameParameter = command.CreateParameter();
            nameParameter.ParameterName = "@id";
            nameParameter.Value = id;
            command.Parameters.Add(nameParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();
            connection.Close();
            return ret;
        }

        public Category GetCategoryById(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Category WHERE CategoryId = @Id";
            command.CommandType = CommandType.Text;

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@Id";
            idParameter.Value = id;
            command.Parameters.Add(idParameter);

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            Category obj = new Category();
            if (reader.Read())
            {
                obj.Id = (int)reader["CategoryId"];
                obj.Name = (string)reader["CategoryName"];
            }

            reader.Close();
            connection.Close();

            return obj;
        }
    }
}
