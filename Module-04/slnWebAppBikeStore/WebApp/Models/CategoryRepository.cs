using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class CategoryRepository : BaseRepository
    {
        //IConfiguration configuration;

        public CategoryRepository(IConfiguration configuration) : base(configuration)
        {
            //this.configuration = configuration;
        }

        public int Edit(Category obj)
        {
            string sql = "UPDATE production.Category SET CategoryName = @Name WHERE CategoryId = @Id";
            Parameter[] parameters =
            {
                new Parameter {Name = "@Id", Value=obj.Id},
                new Parameter {Name = "@Name", Value=obj.Name}
            };
            return Save(sql, parameters);
        }

        public int Edit2(Category obj)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE production.Category SET CategoryName = @Name WHERE CategoryId = @Id";
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

                    return command.ExecuteNonQuery();
                }
            }
        }

        public Category GetCategoryById(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM production.Category WHERE CategoryId = @Id";
                    command.CommandType = CommandType.Text;

                    IDataParameter idParameter = command.CreateParameter();
                    idParameter.ParameterName = "@Id";
                    idParameter.Value = id;
                    command.Parameters.Add(idParameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Category()
                            {
                                Id = (short)reader["CategoryId"],
                                Name = (string)reader["CategoryName"]
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public int Delete(int id)
        {
            string sql = "DELETE FROM production.Category WHERE CategoryId = @Id";
            return Save(sql, new Parameter { Name = "@Id", Value = id });
        }

        public int Delete(int[] a)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"DELETE FROM production.Category WHERE CategoryId IN({string.Join(',', a)})";
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Delete2(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM production.Category WHERE CategoryId = @Id";
                    command.CommandType = CommandType.Text;

                    IDataParameter idParameter = command.CreateParameter();
                    idParameter.ParameterName = "@Id";
                    idParameter.Value = id;
                    command.Parameters.Add(idParameter);

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Add(Category obj)
        {
            string sql = "INSERT INTO production.Category (CategoryName) VALUES (@Name)";
            return Save(sql, new Parameter { Name = "@Name", Value = obj.Name });
        }

        public int Add2(Category obj)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO production.Category (CategoryName) VALUES (@Name)";
                    command.CommandType = CommandType.Text;

                    IDataParameter nameParameter = command.CreateParameter();
                    nameParameter.ParameterName = "@Name";
                    nameParameter.Value = obj.Name;
                    command.Parameters.Add(nameParameter);

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }

        public List<Category> GetCategories()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM production.Category";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Category> list = new List<Category>();
                        while (reader.Read())
                        {
                            list.Add(new Category
                            {
                                Id = (short)reader["CategoryId"],
                                Name = (string)reader["CategoryName"]
                            });
                        }
                        return list;
                    }
                }
            }
        }
    }
}
