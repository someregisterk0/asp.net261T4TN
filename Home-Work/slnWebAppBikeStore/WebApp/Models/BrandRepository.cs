using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class BrandRepository : Controller
    {
        IConfiguration configuration;

        public BrandRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Brand> GetBrands()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM production.Brand";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Brand> list = new List<Brand>();
                        while (reader.Read())
                        {
                            list.Add(new Brand
                            {
                                Id = (short)reader["BrandId"],
                                Name = (string)reader["BrandName"]
                            });
                        }
                        return list;
                    }
                }
            }
        }

        public int Add(Brand obj)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO production.Brand (BrandName) VALUES (@Name)";
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
    }
}
