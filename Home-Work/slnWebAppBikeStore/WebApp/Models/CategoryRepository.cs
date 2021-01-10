using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class CategoryRepository
    {
        IConfiguration configuration;

        public CategoryRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int Add(Category obj)
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
                        while(reader.Read())
                        {
                            list.Add(new Category { 
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
