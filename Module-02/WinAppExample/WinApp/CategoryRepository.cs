﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class CategoryRepository : BaseRepository
    {
        public int Delete2(int id)
        {
            Parameter parameter = new Parameter { Name = "@Id", Value = id };

            // Gọi Procedure
            // return Save("DeleteCategory", parameter); 

            // Gọi bằng command Text
            string sql = "DELETE FROM Category WHERE CategoryId = @Id";
            return Save(sql, parameter, CommandType.Text);
        }

        public int Add2(Category obj)
        {
            string sql = "INSERT INTO Category VALUES (@name)";
            return Save(sql, new Parameter { Name = "@name", Value = obj.Name }, CommandType.Text);
        }

        public int Edit2(Category obj)
        {
            string sql = "UPDATE Category SET CategoryName = @Name WHERE CategoryId = @Id";
            Parameter[] parameters =
            {
                new Parameter{Name = "@Name", Value = obj.Name},
                new Parameter{Name = "@Id", Value = obj.Id}
            };
            return Save(sql, parameters, CommandType.Text);
        }

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

        public List<Category> GetCategories2()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Category";
                    connection.Open();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Category> list = new List<Category>();
                        while (reader.Read())
                        {
                            list.Add(new Category
                            {
                                Id = (int)reader["CategoryId"],
                                Name = (string)reader["CategoryName"]
                            });
                        }
                        return list;
                    }
                }
            }
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

        public int Edit(Category obj)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Category SET CategoryName = @Name WHERE CategoryId = @Id";
            command.CommandType = CommandType.Text;

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@Id";
            idParameter.Value = obj.Id;
            command.Parameters.Add(idParameter);

            IDataParameter nameParameter = command.CreateParameter();
            nameParameter.ParameterName = "@Name";
            nameParameter.Value = obj.Name;
            command.Parameters.Add(nameParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();

            connection.Close();

            return ret;
        }
    }
}
